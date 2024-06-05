using ProductManagementApp.DBContext;
using ProductManagementApp.Models;

namespace ProductManagementApp.Repository
{
    public class ProductRepository
    {
        private ProductDBContext _context;

        public ProductRepository(ProductDBContext context) 
        {
            _context = context;
        }

        public List<Product> GetAll() 
        {
            var products = _context.Products.ToList();
            return products;
        }

        public Product ProductById(int id) 
        {
          Product product = _context.Products.FirstOrDefault(prod => prod.ProductId == id);
          return product;
        }

        public bool Insert(Product product) 
        {
            bool status = false;
            _context.Products.Add(product);
            _context.SaveChanges();
            status = true;
            return status;
        }

        public bool Update(Product prod)
        {
            bool status = false;
            _context.Products.Update(prod);
            _context.SaveChanges();
            status = true;
            return status;
        }

        public bool Remove(int id) 
        {
            bool status = false;
            var prodToRemove = _context.Products.FirstOrDefault(prod => prod.ProductId == id);
            if (prodToRemove != null) 
            {
                _context.Products.Remove(prodToRemove);
                _context.SaveChanges();
                status = true;
            }
            return status;

        }




    }
}
