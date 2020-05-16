using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using HealthyNutGuysDomain.Models;

namespace HealthyNutGuysDataCore.DataBaseInitializer
{
    public class IdentitySeedData
    {
        private static readonly string AdminRole = "admin";
        private static readonly string SuperUserRole = "superuser";
        private static readonly string UserRole = "user";
        private static readonly string Permission = "permission";
        private static readonly string ModifyPermission = "modify";
        private static readonly string RetrievePermission = "retrieve";
        private static readonly string ViewPermission = "view";

        public async static Task Populate(IServiceProvider serviceProvider)
        {
            UserManager<ApplicationUser> userManager = serviceProvider.GetService<UserManager<ApplicationUser>>();
            RoleManager<IdentityRole> roleManager = serviceProvider.GetService<RoleManager<IdentityRole>>();
            IConfiguration configuration = serviceProvider.GetService<IConfiguration>();

            HealthyNutGuysContext dbContext = serviceProvider.GetService<HealthyNutGuysContext>();

            await Seed(userManager, roleManager, configuration, dbContext);
        }

        private async static Task Seed(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, IConfiguration configuration, HealthyNutGuysContext dbContext)
        {
            // HealthyNutGuysRole[] roles = new HealthyNutGuysRole [] { HealthyNutGuysRole.User, HealthyNutGuysRole.Admin };
            string[] roles = new string[] { AdminRole, SuperUserRole, UserRole };

            foreach (string role in roles)
            {
                if (!roleManager.Roles.Any(r => r.Name == role))
                {
                    IdentityRole newRole = new IdentityRole
                    {
                        Name = role,
                        NormalizedName = role.ToUpper()
                    };
                    await roleManager.CreateAsync(newRole);

                    if (role == AdminRole)
                    {
                        await roleManager.AddClaimAsync(newRole, new Claim(Permission, ModifyPermission));
                    }
                    else if (role == SuperUserRole)
                    {
                        await roleManager.AddClaimAsync(newRole, new Claim(Permission, RetrievePermission));
                    }
                    else
                    {
                        await roleManager.AddClaimAsync(newRole, new Claim(Permission, ViewPermission));
                    }
                }
            }

            ApplicationUser admin1 = new ApplicationUser
            {
                UserName = "jsprague@gmail.com",
                Email = "jsprague@gmail.com",
                FirstName = "Jordan",
                LastName = "Legs",
                PhoneNumber = "555-666-4545",                
            };

            ApplicationUser admin2 = new ApplicationUser
            {
                UserName = "nwolf@gmail.com",
                Email = "nwolf@gmail.com",
                FirstName = "Nick",
                LastName = "HanglySack",
                PhoneNumber = "800-123-3455"
            };

            ApplicationUser sysAdmin = new ApplicationUser
            {
                UserName = "omikolaj1@gmail.com",
                Email = "omikolaj1@gmail.com",
                FirstName = "Oskar",
                LastName = "Mikolajczyk"
            };

            PasswordHasher<ApplicationUser> password = new PasswordHasher<ApplicationUser>();

            if (!userManager.Users.Any(u => u.UserName == admin1.UserName))
            {
                string hashed = password.HashPassword(admin1, configuration["THNG:HealthyNutGuysAdminInitPassword"]);
                admin1.PasswordHash = hashed;

                await userManager.CreateAsync(admin1);
                await userManager.AddToRoleAsync(admin1, AdminRole);
            }

            if (!userManager.Users.Any(u => u.UserName == admin2.UserName))
            {
                string hashed = password.HashPassword(admin2, configuration["THNG:HealthyNutGuysAdminInitPassword"]);
                admin2.PasswordHash = hashed;

                await userManager.CreateAsync(admin2);
                await userManager.AddToRoleAsync(admin2, AdminRole);
            }

            if (!userManager.Users.Any(u => u.UserName == sysAdmin.UserName))
            {
                string hashed = password.HashPassword(sysAdmin, configuration["THNG:HealthyNutGuysAdminInitPassword"]);
                sysAdmin.PasswordHash = hashed;

                await userManager.CreateAsync(sysAdmin);
                await userManager.AddToRoleAsync(sysAdmin, AdminRole);
            }
            
            Address admin1Address = new Address()
            {
                Id = "1",
                FullName = $"{admin1.FirstName} {admin1.LastName}",
                ApplicationUserId = admin1.Id,
                Address1 = "7216 Covert Ave",
                City = "Cleveland",
                PostCode = "44105",
                ApplicationUser = admin1
            };

            Address admin2Address = new Address()
            {
                Id = "2",
                FullName = $"{admin2.FirstName} {admin2.LastName}",
                ApplicationUserId = admin2.Id,
                Address1 = "654 Somewhere in Texas",
                City = "Dallas",
                PostCode = "70500",
                ApplicationUser = admin2
            };

            Address sysAdminAddress = new Address()
            {
                Id = "3",
                FullName = $"{sysAdmin.FirstName} {sysAdmin.LastName}",
                ApplicationUserId = sysAdmin.Id,
                Address1 = "8888 Park Ave",
                City = "Parma Heights",
                PostCode = "44133",
                ApplicationUser = sysAdmin
            };

            List<Address> addresses = new List<Address>
            {
                admin1Address,
                admin2Address,
                sysAdminAddress
            };

            if (dbContext.Addresses.Count() < addresses.Count)
            {
                foreach (Address address in addresses)
                {
                    dbContext.Addresses.Add(address);
                    dbContext.SaveChanges();
                }
            }
        }

    }
}
