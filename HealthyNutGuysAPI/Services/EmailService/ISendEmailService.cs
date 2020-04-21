using Services.EmailService;
using HealthyNutGuysDomain.ViewModels.Merchandise;
using HealthyNutGuysDomain.ViewModels.Team;

namespace Services.EmailService
{
  public interface ISendEmailService
  {
    bool SendEmail(TeamSignUpFormViewModel email);
    bool SendEmail(PreOrderViewModel email, GearItemViewModel gearItemPreOrder);
  }
}