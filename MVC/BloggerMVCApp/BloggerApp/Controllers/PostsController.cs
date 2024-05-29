using Microsoft.AspNetCore.Mvc;

namespace BloggerApp.Controllers
{
    public class PostsController : Controller
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
