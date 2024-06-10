using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StateManagementApp.Models;

namespace StateManagementApp.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            Claim theClaim = new Claim()
            {
                Email = "",
                Password = ""
            };
            return View();
        }
        [HttpPost]
        public IActionResult Login(Claim theClaim)
        {
            if(theClaim.Email == "akshayw2512@gmail.com" && theClaim.Password=="Bhupendraw")
            {
                return RedirectToAction("Index", "Home");
            }
            return View(theClaim);
        }
    }
}
