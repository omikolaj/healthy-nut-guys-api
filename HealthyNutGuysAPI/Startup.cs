﻿using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Logging;
using Serilog;
using HealthyNutGuysAPI.Configurations;
using HealthyNutGuysAPI.Extensions;
using HealthyNutGuysAPI.Middleware;
using HealthyNutGuysAPI.MIddleware;
using Microsoft.Extensions.Hosting;
using AspNetCore.RouteAnalyzer;

namespace HealthyNutGuysAPI
{
    public class Startup
    {
        #region Properties and Fields
        private readonly Microsoft.Extensions.Logging.ILogger _logger;

        #endregion
        public Startup(IConfiguration configuration, ILogger<Startup> logger)
        {
            Configuration = configuration;
            this._logger = logger;
        }

        static Func<RedirectContext<CookieAuthenticationOptions>, Task> ReplaceRedirector(HttpStatusCode statusCode, Func<RedirectContext<CookieAuthenticationOptions>, Task> existingRedirector) =>
        context =>
        {
            if (context.Request.Path.StartsWithSegments("/api/v1"))
            {
                context.Response.StatusCode = (int)statusCode;
                return Task.CompletedTask;
            }
            return existingRedirector(context);
        };

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            try
            {
                this._logger.LogInformation("Configuring services");
                services.AddEntityFrameworkSqlServer()
                        .AddConnectionProvider(Configuration)
                        .ConfigureRepositories()
                        .ConfigureSupervisor()
                        .AddJsonOptions()
                        .AddCorsConfiguration(Configuration)
                        .AddIdentityConfiguration()
                        .ConfigureApplicationCookies()
                        .ConfigureJsonWebToken(Configuration)
                        .ConfigureControllersFilters()
                        .ConfigureCloudinaryService(Configuration)
                        .ConfigureEmailSetUp()
                        .ConfigureHttpCachingProfiles()
                        .RemoveNull204Formatter();                        
                        //.AddSpaStaticFiles(spa =>
                        //{
                        //    spa.RootPath = "wwwroot";
                        //});
            }
            catch (Exception ex)
            {
                this._logger.LogError(ex, "Error occured while configuring services");
            }
            services.AddRazorPages();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IServiceProvider serviceProvider)
        {
            try
            {
                if (env.IsDevelopment())
                {
                    app.UseDeveloperExceptionPage();
                    app.UseCors("AllowAllWithClientOrigin");
                }
                else
                {
                    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                    app.UseHsts();
                }

                // Middleware has to be registered first, otherwise we get a bearer challenge 401 error
                app.UseMiddleware<JwtBearerMiddleware>()
                    .UseRouting()
                    .UseCors("AllowAll")
                    .UseAuthentication()
                    .SeedDatabase();
                //.UseHttpsRedirection()
                //.UseSecurityHeaders();

                //app.UseSpaStaticFiles(new StaticFileOptions
                //{
                //    FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "fonts")),
                //    RequestPath = "/wwwroot/fonts",
                //    OnPrepareResponse = ctx =>
                //    {
                //        ctx.Context.Response.Headers.Append("Cache-Control", "private, max-age=86400, stale-while-revalidate=604800");
                //    }
                //});

                //app.UseSpaStaticFiles(new StaticFileOptions
                //{
                //    OnPrepareResponse = ctx =>
                //    {
                //        ctx.Context.Response.Headers.Append("Cache-Control", "max-age=31536000");
                //    }
                //});

                //app.UseSpa(spa =>
                //{
                //    spa.Options.SourcePath = "wwwroot";
                //});

                // may be unecessary 
                app.UseEndpoints(endpoints =>
                {
                    endpoints.MapControllers();
                });
            }
            catch (Exception ex)
            {
                this._logger.LogError(ex, "Fatal error occured while configuring the app");
            }
        }
    }
}
