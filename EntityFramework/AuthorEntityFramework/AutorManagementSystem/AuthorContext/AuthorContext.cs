using AuthorManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuthorManagementSystem.DBContext
{
    public class AuthorContext : DbContext
    {
        public string connectionString = @"Data Source=DESKTOP-7RMUKTV\SQLEXPRESS;Initial Catalog=assessmentdb;Integrated Security=True;Connect Timeout=30;Encrypt=False";

        public DbSet<Author> Author { get; set; }
        public DbSet<Blog> Blog { get; set; }
        public DbSet<Post> Post { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

    }
}
