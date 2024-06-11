using CookiesManagementApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CookiesManagementApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult CreateCookies()
        {
            string key = "DemoCookie";
            string value = "Bhupendra";
            CookieOptions obj = new CookieOptions();
            obj.Expires = DateTime.Now.AddMinutes(10);
            Response.Cookies.Append(key, value, obj);
            return View();
        }

        public IActionResult DisplayCookie()
        {
            string key = "DemoCookie";
            var CookieValue = Request.Cookies[key];
            ViewBag.cookieVal = CookieValue;
            return View();
        }

        public IActionResult ReadQueryString(int productId)
        {
            int prodId = productId;
            ViewBag.product = prodId;
            return View();
        }
    }

}
