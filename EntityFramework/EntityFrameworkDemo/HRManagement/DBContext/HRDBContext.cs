using HRManagement.Entities;
using Microsoft.EntityFrameworkCore;

namespace HRManagement.DBContext
{
    public class HRDBContext : DbContext
    {
      
        public DbSet<Employee> Employees { get; set; }

        public string connectionString = @"Data Source=DESKTOP-7RMUKTV\SQLEXPRESS;Initial Catalog=assessmentdb;Integrated Security=True;Connect Timeout=30;Encrypt=False";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
