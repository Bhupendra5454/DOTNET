using Microsoft.AspNetCore.Mvc;

namespace BloggersParadise.Controllers
{
    public class CustomersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details()
        {
            return View();
        }

        public IActionResult Insert()
        {
            return View();
        }

        public IActionResult Update()
        {
            return View();
        }


    }
}
