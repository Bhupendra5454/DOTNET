﻿using Microsoft.EntityFrameworkCore;

using RegistrationFormApp.Models;

namespace RegistrationFormApp.DataContext
{
    public class DbContextRegisterForm:DbContext
    {
        public DbSet<RegisterForm> RegisterForms { get; set; }

        public string conString = @"server=localhost;port=3306;user=root;password=password;database=dotnet;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(conString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RegisterForm>()
                .Ignore(c => c.LangCheckbox1);

            modelBuilder.Entity<RegisterForm>()
                .Ignore(c => c.LangCheckbox2);

            modelBuilder.Entity<RegisterForm>()
               .Ignore(c => c.LangCheckbox3);
        }
    }
}
