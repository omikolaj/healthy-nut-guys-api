using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using HealthyNutGuysAPI.Auth.Jwt;
using HealthyNutGuysAPI.Auth.Jwt.JwtFactory;
using HealthyNutGuysDomain.Models;

namespace HealthyNutGuysAPI.Auth
{
    public class Token
    {
        #region Fields and Properties
        private readonly IConfiguration _configuration;

        #endregion

        #region Constructor
        public Token(IConfiguration configuration)
        {
            this._configuration = configuration;
        }
        #endregion

        #region Methods
        public static async Task<ApplicationToken> GenerateJwt(string userId,
                                                        ClaimsIdentity identity,
                                                        IJwtFactory jwtFactory,
                                                        JwtIssuerOptions jwtOptions)
        {
            ApplicationToken accessToken = new ApplicationToken
            {
                access_token = await jwtFactory.GenerateEncodedToken(userId, identity),
                expires_in = (long)jwtOptions.ValidFor.TotalSeconds
            };

            return accessToken;
        }
        
        #endregion

    }
}
