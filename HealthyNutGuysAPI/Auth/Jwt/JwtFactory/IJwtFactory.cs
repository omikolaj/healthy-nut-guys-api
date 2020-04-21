using System.Security.Claims;
using System.Threading.Tasks;

namespace HealthyNutGuysAPI.Auth.Jwt.JwtFactory
{
  public interface IJwtFactory
  {
    Task<string> GenerateEncodedToken(string userName, ClaimsIdentity identity);
  }
}