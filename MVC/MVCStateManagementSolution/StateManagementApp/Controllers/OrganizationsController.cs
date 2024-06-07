using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using StateManagementApp.Models;

namespace StateManagementApp.Controllers
{
    public class OrganizationsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            
            University university = new University();
            university.EnggColgList = PopuletColgs();
            
            return View(university);
        }

        [HttpPost]
        public IActionResult Register(University uni, string[] engcolgs)
        {
            uni.EnggColgList = PopuletColgs();
            foreach(SelectListItem item in  uni.EnggColgList) 
            {
                if(item != null)
                {
                    if(engcolgs.Contains(item.Value))
                    {
                       item.Selected= true;
                    }
                }
            }
            Console.WriteLine("Id" + uni.Id + "name" + uni.Name + "Colleges" + uni.EnggColgList);
            ViewData["universitylist"] = uni;
            return RedirectToAction("Index");
        }

        public static List<SelectListItem> PopuletColgs()
        {
            List<SelectListItem> items = new List<SelectListItem>();
            items.Add(new SelectListItem { Text = "College of Engineering Pune", Value = "COEP", Selected = false });
            items.Add(new SelectListItem { Text = "Vishwakarma Institute of Technology", Value = "VIT", Selected = false });
            items.Add(new SelectListItem { Text = "Pune Institute of Computer Technology", Value = "PICT", Selected = false });
            items.Add(new SelectListItem { Text = "Maharashtra Institute of Technology", Value = "MIT", Selected = false });
            return items;
        }
    }
}
