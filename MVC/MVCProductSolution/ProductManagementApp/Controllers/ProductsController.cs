using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using ProductManagementApp.DBContext;
using ProductManagementApp.Models;
using ProductManagementApp.Repository;

namespace ProductManagementApp.Controllers
{
    public class ProductsController : Controller
    {
       
        public IActionResult Index()
        {
            using(ProductDBContext context = new ProductDBContext())
            {
                ProductRepository _repo = new ProductRepository(context); 
                List<Product> products = _repo.GetAll();
                ViewData["allProducts"] = products;
                return View();

            }
            
        }
        public IActionResult Details(int id) 
        {
            using (ProductDBContext context = new ProductDBContext())
            {
                ProductRepository _repo = new ProductRepository(context);
                Product prod = _repo.ProductById(id);
                ViewData["productById"] = prod;
                return View();
            }
               
        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product product) 
        {
            using(ProductDBContext context =new ProductDBContext()) 
            {
                ProductRepository _repo = new ProductRepository(context);
                bool status = _repo.Insert(product);
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            using (ProductDBContext context = new ProductDBContext())
            {
                ProductRepository _repo = new ProductRepository(context);
                Product prod = _repo.ProductById(id);
                return View(prod);
            }

        }
        [HttpPost]
        public IActionResult UpdateProduct(Product product) 
        {
            using(ProductDBContext context = new ProductDBContext())
            {
                ProductRepository _repo=new ProductRepository(context);
                bool status = _repo.Update(product);
            }
            return RedirectToAction("Index");
        }



        
     
    }

    
}
