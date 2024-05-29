using Microsoft.AspNetCore.Mvc;

namespace BloggersParadise.Controllers
{
    public class AuthController : Controller
    {

        //Set of Action methods
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult ForgotPassword()
        {
            return View();
        }
    }
}
