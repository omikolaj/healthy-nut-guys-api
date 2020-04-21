using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using HealthyNutGuysAPI.Auth.Jwt;
using HealthyNutGuysDomain;
using HealthyNutGuysDomain.Converters;
using HealthyNutGuysDomain.Models;
using HealthyNutGuysDomain.Supervisor;
using HealthyNutGuysDomain.ViewModels;

namespace HealthyNutGuysAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class UsersController : HealthyNutGuysBaseController
    {
        #region Fields and Properties
        private readonly IHealthyNutGuysSupervisor _supervisor;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly CloudinaryService _cloudinaryService;

        #endregion

        #region Constructor
        public UsersController(IHealthyNutGuysSupervisor supervisor, UserManager<ApplicationUser> userManager)
        {
            this._supervisor = supervisor;
            this._userManager = userManager;
        }

        #endregion

        #region Controllers

        [HttpGet("{id}/roles")]
        [Produces(typeof(IList<string>))]
        public async Task<ActionResult<IList<string>>> GetUserRoles(string userId, CancellationToken ct = default(CancellationToken))
        {
            Claim userIdClaim = User.Claims.Where(c => c.Type == Constants.Strings.JwtClaimIdentifiers.Id).FirstOrDefault();

            ApplicationUser user = _userManager.Users.SingleOrDefault(u => u.Id == userIdClaim.Value);

            if (user == null)
            {
                return BadRequest();
            }

            IList<string> roles = await this._userManager.GetRolesAsync(user);

            return new JsonResult(roles);
        }

        #endregion
    }
}