using HealthyNutGuysDomain.Models.TeamSignUp;
using HealthyNutGuysDomain.ViewModels.Team;

namespace HealthyNutGuysDomain.Converters.TeamConverters
{
  public static class TeamSignUpFormConverter
  {
    #region Methods
    public static TeamSignUpFormViewModel Convert(TeamSignUpForm TeamSignUpForm)
    {
      TeamSignUpFormViewModel TeamSignUpFormViewModel = new TeamSignUpFormViewModel();
      TeamSignUpFormViewModel.Id = TeamSignUpForm.Id;
      TeamSignUpFormViewModel.Name = TeamSignUpForm.Name;
      TeamSignUpFormViewModel.Contact = ContactConverter.Convert(TeamSignUpForm.Contact);

      return TeamSignUpFormViewModel;
    }
    #endregion
  }
}