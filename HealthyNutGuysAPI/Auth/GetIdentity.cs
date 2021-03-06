using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using HealthyNutGuysAPI.Auth.Jwt;
using HealthyNutGuysDomain.Models;

namespace HealthyNutGuysAPI.Auth
{
    public class GetIdentity
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public GetIdentity(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public async Task<ClaimsIdentity> GetClaimsIdentity(ApplicationUser userToVerify, string password)
        {
            if (userToVerify == null || string.IsNullOrEmpty(password))
                return await Task.FromResult<ClaimsIdentity>(null);

            if (userToVerify == null) return await Task.FromResult<ClaimsIdentity>(null);

            // check the credentials
            if (await _userManager.CheckPasswordAsync(userToVerify, password))
            {
                return await GenerateClaimsIdentity(userToVerify);
            }

            // Credentials are invalid, or account doesn't exist
            return await Task.FromResult<ClaimsIdentity>(null);
        }

        public async Task<ClaimsIdentity> GenerateClaimsIdentity(ApplicationUser user)
        {
            // Create claims List
            var claims = new List<Claim>()
            {
                new Claim(Constants.Strings.JwtClaimIdentifiers.Id, user.Id),                
            };

            // Retrieve user claims
            var userClaims = await _userManager.GetClaimsAsync(user);
            // Retrieve user roles
            var userRoles = await _userManager.GetRolesAsync(user);

            claims.AddRange(userClaims);
            foreach (var userRole in userRoles)
            {
                claims.Add(new Claim(Constants.Strings.JwtClaimIdentifiers.Role, userRole));
                var role = await _roleManager.FindByNameAsync(userRole);
                if (role != null)
                {
                    var roleClaims = await _roleManager.GetClaimsAsync(role);
                    foreach (Claim roleClaim in roleClaims)
                    {
                        claims.Add(roleClaim);
                    }
                }
            }

            return new ClaimsIdentity(new GenericIdentity(user.UserName, "Token"), claims);
        }
    }
}