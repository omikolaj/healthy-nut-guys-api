using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyNutGuysAPI.Configurations
{
    public static class RemoveNullFormatter
    {
        public static IServiceCollection RemoveNull204Formatter(this IServiceCollection services)
        {
            services.AddControllers(opt =>
            {
                // remove formatter that turns nulls into 204 - Angular http client treats 204s as failed requests
                opt.OutputFormatters.RemoveType<HttpNoContentOutputFormatter>();
            });

            return services;
        }
    }
}
