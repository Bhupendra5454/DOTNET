using Microsoft.AspNetCore.Mvc;

namespace BloggerApp.Controllers
{
    public class BlogsController : Controller
    {
        public IActionResult Jaipur()
        {
            return View();
        }

        public IActionResult Jodhpur()
        {
            return View();
        }
    }
}
