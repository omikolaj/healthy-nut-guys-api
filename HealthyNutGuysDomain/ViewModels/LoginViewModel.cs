using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace HealthyNutGuysDomain.ViewModels
{
  public class LoginViewModel
  {
    [Required]
    public string UserName { get; set; }

    [Required, DataType(DataType.Password)]
    public string Password { get; set; }
    public string NewPassword { get; set; }
    public ClaimsIdentity Claims { get; set; }

  }
}