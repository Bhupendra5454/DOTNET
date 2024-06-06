using Microsoft.AspNetCore.Mvc;
using RegistrationFormApp.Models;
using System.Diagnostics;

namespace RegistrationFormApp.Controllers
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
        public IActionResult AboutUs()
        {
            List<string> messages = new List<string>();
            messages.Add("we are students..");
            messages.Add("TFL institute");
            ViewBag.Aboutus = messages;
            return View();
        }
        public IActionResult Contact()
        {
            List<string> cities = (List<string>)TempData["tempServ"];
         
            ViewData["allCities"]=cities;

            return View();
        }
        public IActionResult Services()
        {
            List<string> serv = new List<string>();
            serv.Add("Teching");
            serv.Add("guidance");
            TempData["tempServ"]=serv;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
