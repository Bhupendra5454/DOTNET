using Microsoft.AspNetCore.Mvc;

namespace StateManagementApp.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
