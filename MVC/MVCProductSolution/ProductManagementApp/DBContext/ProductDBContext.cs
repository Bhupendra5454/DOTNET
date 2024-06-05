using Microsoft.EntityFrameworkCore;
using ProductManagementApp.Models;

namespace ProductManagementApp.DBContext
{
    public class ProductDBContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public string connectionString = @"Data Source=DESKTOP-7RMUKTV\SQLEXPRESS;Initial Catalog=assessmentdb;Integrated Security=True;Connect Timeout=30;Encrypt=False";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }


    }
}
