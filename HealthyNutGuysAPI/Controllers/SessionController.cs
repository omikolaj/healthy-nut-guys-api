using System;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using HealthyNutGuysAPI.Auth;
using HealthyNutGuysAPI.Auth.Errors;
using HealthyNutGuysAPI.Auth.Jwt;
using HealthyNutGuysAPI.Auth.Jwt.JwtFactory;
using HealthyNutGuysAPI.Filters;
using HealthyNutGuysAPI.Helpers;
using HealthyNutGuysDomain;
using HealthyNutGuysDomain.Converters;
using HealthyNutGuysDomain.Models;
using HealthyNutGuysDomain.ViewModels;

namespace HealthyNutGuysAPI.Controllers
{
    [AllowAnonymous]
    [Route("api/")]
    [Produces("application/json")]
    [ServiceFilter(typeof(ValidateModelStateAttribute))]
    public class SessionController : HealthyNutGuysBaseController
    {
        #region Fields and Properties

        private readonly IHealthyNutGuysSupervisor _supervisor;
        private readonly IJwtFactory _jwtFactory;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly GetIdentity _getIdentity;
        private readonly JwtIssuerOptions _jwtOptions;

        #endregion

        #region Constructor
        public SessionController(
          IHealthyNutGuysSupervisor supervisor,
          IJwtFactory jwtFactory,
          IOptions<JwtIssuerOptions> jwtOptions,
          UserManager<ApplicationUser> userManager,
          GetIdentity getIdentity)
        {
            this._supervisor = supervisor;
            this._jwtFactory = jwtFactory;
            this._userManager = userManager;
            this._jwtOptions = jwtOptions.Value;
            this._getIdentity = getIdentity;
        }

        #endregion

        #region Controllers

        [HttpPost("login")]
        public async Task<ActionResult> Login([FromBody] ApplicationUserViewModel user, CancellationToken ct = default(CancellationToken))
        {
            ApplicationUser appUser = _userManager.Users.SingleOrDefault(u => u.Email == user.Email);

            ClaimsIdentity identity = await _getIdentity.GetClaimsIdentity(appUser, user.Password);

            if (identity == null)
            {
                return Unauthorized(Errors.AddErrorToModelState(ErrorCodes.Login, ErrorDescriptions.LoginFailure, ModelState));
            }

            ApplicationToken token = await Token.GenerateJwt(appUser.Id, identity, this._jwtFactory, this._jwtOptions);

            return new OkObjectResult(token);
        }

        [HttpPost("signup")]
        public async Task<ActionResult<bool>> RegisterUser([FromBody] ApplicationUserViewModel newUser, CancellationToken ct = default(CancellationToken))
        {
            newUser = await this._supervisor.CreateUserAsync(newUser);
            if(newUser == null)
            {
                return BadRequest("Error occured creating user");
            }

            ApplicationUser appUser = _userManager.Users.SingleOrDefault(u => u.Email == newUser.Email);

            ClaimsIdentity identity = await _getIdentity.GenerateClaimsIdentity(appUser);

            ApplicationToken token = await Token.GenerateJwt(appUser.Id, identity, this._jwtFactory, this._jwtOptions);

            return new OkObjectResult(token);
        }

        [HttpDelete("logout")]
        public async Task<ActionResult<bool>> Logout(long userId, CancellationToken ct = default(CancellationToken))
        {
            // there is no way to invalidate JWTs
            // one solution is to keep a black list of JWTs that are valid but have been logged out
            // then use middleware that will check to see if someone is accessing the authroized endpoint 
            // with a blacklisted jwt. The blacklist can be kept in memory store such as reddis
            return new OkObjectResult(true);
        }

        #endregion

    }
}