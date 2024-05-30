using Microsoft.AspNetCore.Mvc;
using TFLECommerce_May2024.Models;

namespace TFLECommerce_May2024.Controllers
{
    public class CustomersController : Controller
    {
        public IActionResult Index(List<Customer> customer)
        {
            List<Customer> customers = customer;
            foreach(Customer customer1 in customers) 
            {
                Console.WriteLine(customer1.Name);
            }
            ViewData["allcustomers"] = customers;
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }
    }
}
