using Microsoft.AspNetCore.Mvc;
using SecureRolesWebApp.Models;
using SecureRolesWebApp.Services;
using SecureRolesWebApp.Filters;

namespace SecureRolesWebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : Controller
    {
        private IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }
        

        [HttpPost("authenticate")]
        public IActionResult Authenticate(AuthenticateRequest model)
        {
            var response = _userService.Authenticate(model);
            if(response == null) 
            {
                return BadRequest(new { message = "Username or Password is incorrect" });
            }
            return Ok(response);
        }

        [Authorize]
        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _userService.GetAll();
            return Ok(users);   
        }





    }
}
