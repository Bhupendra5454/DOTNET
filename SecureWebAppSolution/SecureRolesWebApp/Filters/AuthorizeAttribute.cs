using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using SecureRolesWebApp.Entities;

namespace SecureRolesWebApp.Filters;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class AuthorizeAttribute : Attribute,IAuthorizationFilter
{
    public string Role {  get; set; }
    public void OnAuthorization(AuthorizationFilterContext context)
    {
        var user = (User)context.HttpContext.Items["User"];
        var userRole = (string)context.HttpContext.Items["Role"];
        if (user == null)
        {
            context.Result = new JsonResult(new { message = "Unauthorized" }) { StatusCode = StatusCodes.Status401Unauthorized };
        }
        else
        {
            if (Role != userRole)
            {
                context.Result = new JsonResult(new { message = "Unathorized access for your role : " + userRole }) { StatusCode = StatusCodes.Status401Unauthorized };
            }
        }
    }
}
