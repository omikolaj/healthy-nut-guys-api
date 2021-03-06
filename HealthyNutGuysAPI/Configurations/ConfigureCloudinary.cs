using CloudinaryDotNet;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HealthyNutGuysAPI.Configurations
{
  public static class ConfigureCloudinary
  {
    public static IServiceCollection ConfigureCloudinaryService(this IServiceCollection services, IConfiguration configuration)
    {
      services.AddTransient<CloudinaryService>();

      return services;
    }
  }
}