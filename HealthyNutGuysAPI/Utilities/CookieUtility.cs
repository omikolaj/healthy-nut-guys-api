using System;
using Microsoft.AspNetCore.Http;
using HealthyNutGuysDomain.Models;

namespace HealthyNutGuysAPI.Utilities
{
  public class CookieUtility
  {
    private static readonly CookieOptions _cookieOptions = new CookieOptions()
    {
      Expires = DateTime.Now.AddDays(14),
      SameSite = SameSiteMode.None,
      HttpOnly = true
    };
    public static void GenerateHttpOnlyCookie(HttpResponse response, string cookieName, ApplicationToken token)
    {
      response.Cookies.Append(cookieName, token.access_token, _cookieOptions);
    }

    public static void RemoveCookie(HttpResponse response, string cookieName)
    {
      response.Cookies.Delete(cookieName);
    }
  }
}