using Microsoft.AspNetCore.Mvc;

namespace BloggerApp.Controllers
{
    public class BloggerController : Controller
    {
        public IActionResult Details()
        {
            return View();
        }

        public IActionResult Blogs()
        {
            return View();
        }

        public IActionResult Posts()
        {
            return View();
        }



    }
}
