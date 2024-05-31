using Microsoft.AspNetCore.Mvc;
using TFLECommerce_May2024.Models;
using TFLECommerce_May2024.Repository;

namespace TFLECommerce_May2024.Controllers
{
    public class CustomersController : Controller
    {
        public IActionResult Index()
        {
            CustomerRepositorycs repo = new CustomerRepositorycs();
            List<Customer> allCustomers = repo.GetAll();
            ViewData["allcustomers"] = allCustomers;
            return View();
        }

        public IActionResult Details(int id)
        {
            CustomerRepositorycs repo = new CustomerRepositorycs();
            List<Customer> customers = repo.GetAll();
            Customer theCustomer = customers.Find(x => x.Id == id);
            ViewData["id"] = theCustomer.Id;
            ViewData["name"] = theCustomer.Name;
            ViewData["email"] = theCustomer.Email;
            ViewData["phone"] = theCustomer.Phone;
            

            return View();
        }
    }
}
