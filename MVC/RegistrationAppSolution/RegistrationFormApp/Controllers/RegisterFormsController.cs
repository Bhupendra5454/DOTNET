using Microsoft.AspNetCore.Mvc;
using RegistrationFormApp.Models;
using RegistrationFormApp.Services;
using static Org.BouncyCastle.Bcpg.Attr.ImageAttrib;

namespace RegistrationFormApp.Controllers
{
    public class RegisterFormsController : Controller
    {
        private IRegisterService _registerService;
   
        public RegisterFormsController(IRegisterService registerService)
        {
            _registerService = registerService;
        }
        public IActionResult Index()
        {
            List<RegisterForm> forms = _registerService.GetAll();
            ViewData["list"]=forms;
            return View();
        }
        [HttpGet]
        public IActionResult Insert()
        {
           
            return View();
        }
        [HttpPost]
        public IActionResult Insert(RegisterForm formdata)
        {
            formdata.Languages = $"{formdata.LangCheckbox1},{formdata.LangCheckbox2},{formdata.LangCheckbox3}";
            bool status= _registerService.Add(formdata);
            return RedirectToAction("Index");
        }
    }
}
