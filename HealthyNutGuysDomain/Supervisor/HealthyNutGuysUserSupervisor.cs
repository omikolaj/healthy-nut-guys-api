using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using HealthyNutGuysDomain.Converters;
using HealthyNutGuysDomain.Models;
using HealthyNutGuysDomain.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace HealthyNutGuysDomain.Supervisor
{
    public partial class HealthyNutGuysSupervisor : IHealthyNutGuysSupervisor
    {
        #region Methods
        public async Task<ApplicationUserViewModel> CreateUserAsync(ApplicationUserViewModel userViewModel, CancellationToken ct = default)
        {
            ApplicationUser newUser = new ApplicationUser();
            newUser.FirstName = userViewModel.FirstName;
            newUser.LastName = userViewModel.LastName;
            newUser.Email = userViewModel.Email;
            newUser.UserName = userViewModel.Email;
            newUser.PhoneNumber = userViewModel.PhoneNumber;

            IdentityResult result = await this._userManager.CreateAsync(newUser, userViewModel.Password);

            if (result.Succeeded)
            {
                userViewModel.Id = newUser.Id;
                return userViewModel;
            }

            return null;

        }



        public Task<bool> DeleteUserAsync(string id, CancellationToken ct = default)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<ApplicationUserViewModel>> GetAllUsersAsync(CancellationToken ct = default)
        {
            throw new System.NotImplementedException();
        }

        public async Task<ApplicationUserViewModel> GetUserByIDAsync(string id, CancellationToken ct = default)
        {
            ApplicationUserViewModel userViewModel = ApplicationUserConverter.Convert(await _applicationUserRepository.GetByIDAsync(id, ct));

            // Retrieve navigational properties here if necessary
            // userViewModel.Comments = await GetAllCommentsByUserIdAsync(id, ct);

            return userViewModel;
        }

        public Task<bool> UpdateUserAsync(ApplicationUserViewModel userViewModel, CancellationToken ct = default)
        {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}