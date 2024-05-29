using Microsoft.AspNetCore.Mvc;

namespace BloggersParadise.Controllers
{

    //Normal MVC Controller
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }
    }
}
