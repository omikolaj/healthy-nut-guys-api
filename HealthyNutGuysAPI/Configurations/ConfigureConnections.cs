using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using HealthyNutGuysDataCore;
using HealthyNutGuysDomain.DbInfo;

namespace HealthyNutGuysAPI.Configurations
{
  public static class ConfigureConnections
  {
    public static IServiceCollection AddConnectionProvider(this IServiceCollection services, IConfiguration configuration)
    {
      string connection = configuration.GetConnectionString("DefaultConnection");


      //string connection = configuration.GetConnectionString("PostgreSQL");

      //Add HealthyNutGuysContext to the DI container          
      services.AddDbContext<HealthyNutGuysContext>(options => 
      {
          options.UseSqlServer(connection);    
      }, ServiceLifetime.Scoped);

      services.AddSingleton(new DbInfo(connection));

      return services;
    }
  }
}