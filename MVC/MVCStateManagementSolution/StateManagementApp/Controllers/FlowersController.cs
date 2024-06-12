using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OutputCaching;

namespace StateManagementApp.Controllers
{
    public class FlowersController : Controller
    {
        [OutputCache]
        public IActionResult Index()
        {
            List<string> flowers = new List<string>();
            flowers.Add("Rose");
            flowers.Add("Jasmin");
            flowers.Add("Lavender");
            return Json(flowers);
        }
    }
}
