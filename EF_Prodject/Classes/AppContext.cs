using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace EF_Prodject.Classes
{
    public class AppContext: DbContext
    {
        // Объекты таблицы Users
        public DbSet<User> Users { get; set; }
        public AppContext() 
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=Mironov;database=EF;Trusted_connection=True;TrustServerCertificate=True;");
        }
    }
}
