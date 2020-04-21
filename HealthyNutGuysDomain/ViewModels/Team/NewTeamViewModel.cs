using HealthyNutGuysDomain.Models.TeamSignUp;

namespace HealthyNutGuysDomain.ViewModels.Team
{
  public class TeamSignUpFormViewModel
  {
    #region Fields and Properties

    public long? Id { get; set; }
    public string Name { get; set; }
    public ContactViewModel Contact { get; set; }

    #endregion
  }
}