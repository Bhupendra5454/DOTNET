using ChartsApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ChartsApp.Controllers
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

        public IActionResult GetData()
        {
            var data = new[]
            {
                new{Year="2020", Placement= 97},
                new{Year="2021", Placement= 95},
                new{Year="2022", Placement= 30},
                new{Year="2023", Placement= 25}
            };
            return Json(data);
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
    }
}
