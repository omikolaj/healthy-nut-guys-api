using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using HealthyNutGuysAPI.Helpers;
using HealthyNutGuysDomain.Models;

namespace HealthyNutGuysAPI.Middleware
{

  public class JwtBearerMiddleware
  {
    private readonly RequestDelegate _next;

    public JwtBearerMiddleware(RequestDelegate next)
    {
      this._next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
      string applicationToken = context.Request.Cookies[TokenOptionsStrings.ApplicationToken];
      if (applicationToken != null)
      {
        context.Request.Headers.Append("Authorization", "Bearer " + applicationToken);
      }

      await _next.Invoke(context);
    }
  }
}