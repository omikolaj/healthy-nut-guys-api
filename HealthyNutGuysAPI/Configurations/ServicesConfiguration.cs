using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using HealthyNutGuysAPI.Auth.Jwt;
using HealthyNutGuysDataCore.Repositories;
using HealthyNutGuysDomain;
using HealthyNutGuysDomain.Repositories;
using HealthyNutGuysDomain.Supervisor;

namespace HealthyNutGuysAPI.Configurations
{
  public static class ServicesConfiguration
  {
    public static IServiceCollection ConfigureRepositories(this IServiceCollection services)
    {
            //Register repository interfaces here      
            services.AddScoped<IApplicationUserRepository, ApplicationUserRepository>()                    
                    .AddScoped<IPromoCodeRepository, PromoCodeRepository>()
                    .AddScoped<ISpecialOfferRepository, SpecialOfferRepository>()
                    .AddScoped<IProductRepository, ProductRepository>()
                    .AddScoped<ISaleItemRepository, SaleItemRepository>()
                    .AddScoped<IMixCategoryRepository, MixCategoryRepository>()
                    .AddScoped<IIngredientRepository, IngredientRepository>()
                    .AddScoped<ICustomProductRepository, CustomProductRepository>();

      return services;
    }

    public static IServiceCollection ConfigureSupervisor(this IServiceCollection services)
    {
      services.AddScoped<IHealthyNutGuysSupervisor, HealthyNutGuysSupervisor>();
      return services;
    }

    public static IServiceCollection ConfigureEmailSetUp(this IServiceCollection services)
    {
      //services.AddScoped<ISendEmailService, SendEmailService>();
      return services;
    }

    public static IServiceCollection AddJsonOptions(this IServiceCollection services)
        {
            services.AddRazorPages().AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            });

            return services;
        }

    public static IServiceCollection AddCorsConfiguration(this IServiceCollection services, IConfiguration configuration)
    {
      IConfigurationSection jwtAppSettingOptions = configuration.GetSection(nameof(JwtIssuerOptions));

      services.AddCors();
            
      services.AddCors(options =>
      {
        options.AddPolicy("AllowAll",
          new Microsoft.AspNetCore.Cors.Infrastructure.CorsPolicyBuilder()            
            .AllowAnyHeader()
            .AllowCredentials()
            .AllowAnyHeader()
            .Build()
          );

          if(configuration["ClientOrigin"] != null)
          {
              options.AddPolicy("AllowAllWithClientOrigin",
            new Microsoft.AspNetCore.Cors.Infrastructure.CorsPolicyBuilder()
              .WithOrigins()
              .AllowAnyHeader()
              .AllowCredentials()
              .AllowAnyHeader()
              .Build()
            );
          }
          
      });

      return services;
    }

  }
}