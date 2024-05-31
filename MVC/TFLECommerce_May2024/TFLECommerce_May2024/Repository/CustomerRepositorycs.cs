using TFLECommerce_May2024.Models;

namespace TFLECommerce_May2024.Repository
{
    public class CustomerRepositorycs
    {
        public List<Customer> GetAll()
        {
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { Id = 54, Name = "Bhupendra Walhekar", Email = "bhupendraw2512@gmail.com", Phone = "9175116616" });
            customers.Add(new Customer { Id = 11, Name = "Vaibhav Lakudzode", Email = "vaibhavl@gmail.com", Phone = "9175116617" });
            customers.Add(new Customer { Id = 45, Name = "Shreedhar Patil", Email = "shreedharp@gmail.com", Phone = "9175116618" });
            customers.Add(new Customer { Id = 97, Name = "Ajinkya Tambade", Email = "ajinkyat@gmail.com", Phone = "9175116619" });
            return customers;

        }
        


    }
}
