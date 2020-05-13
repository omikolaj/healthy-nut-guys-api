using HealthyNutGuysDomain.Models;
using HealthyNutGuysDomain.ViewModels;

namespace HealthyNutGuysDomain.Converters
{
    public static class ApplicationUserConverter
    {
        #region Methods
        public static ApplicationUserViewModel Convert(ApplicationUser user)
        {
            ApplicationUserViewModel model = new ApplicationUserViewModel();
            model.Id = user.Id;
            model.FirstName = user.FirstName;
            model.LastName = user.LastName;
            model.Email = user.Email;            

            model.Password = user.PasswordHash;

            return model;
        }

        #endregion
    }
}