
using Microsoft.Extensions.Logging;
using Solid.Core.Models;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using Solid.Core.Models;
using Microsoft.EntityFrameworkCore;
namespace Solid.Data
{
    public class DataContext:DbContext
   {
        public DbSet <Product> ProductList { get; set; }
        public DbSet <Customer> CustomerList { get; set; }
        public DbSet<Order> OrderList { get; set; }
      
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=sample_db"
);
        }
    }

}
