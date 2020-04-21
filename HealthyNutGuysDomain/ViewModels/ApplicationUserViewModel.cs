using HealthyNutGuysDomain.Models;

namespace HealthyNutGuysDomain.ViewModels
{
  public class ApplicationUserViewModel
  {
    public string Id { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public RefreshToken RefreshToken { get; set; }
  }
}