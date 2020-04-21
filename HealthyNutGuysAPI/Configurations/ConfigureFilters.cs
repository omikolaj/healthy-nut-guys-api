using Microsoft.Extensions.DependencyInjection;
using HealthyNutGuysAPI.Filters;

namespace HealthyNutGuysAPI.Configurations
{
  public static class ConfigureFilters
  {
    public static IServiceCollection ConfigureControllersFilters(this IServiceCollection services)
    {
      services.AddScoped<ValidateModelStateAttribute>()
              .AddScoped<CookieFilter>();

      return services;
    }
  }
}