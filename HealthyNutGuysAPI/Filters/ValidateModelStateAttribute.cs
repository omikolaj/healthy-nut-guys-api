

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace HealthyNutGuysAPI.Filters
{
  public class ValidateModelStateAttribute : IActionFilter
  {
    public void OnActionExecuted(ActionExecutedContext context)
    {
      
    }

    public void OnActionExecuting(ActionExecutingContext context)
    {
      if (!context.ModelState.IsValid)
      {
        context.Result = new BadRequestObjectResult(context.ModelState);
      }
    }
  }
}