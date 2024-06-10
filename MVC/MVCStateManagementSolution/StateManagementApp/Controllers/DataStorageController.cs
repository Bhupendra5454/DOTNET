using Microsoft.AspNetCore.Mvc;

namespace StateManagementApp.Controllers
{
    public class DataStorageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LocalStorage()
        {
            return View();
        }

        public IActionResult SessionStorage()
        {
            return View();
        }
    }
}
