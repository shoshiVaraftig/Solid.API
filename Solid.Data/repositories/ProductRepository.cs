using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solid.Core.Repositories;
using Solid.Core.Models;

namespace Solid.Data.repositories
{
    public class ProductRepository:IProductRepository
    {
        private readonly DataContext _context;
        public ProductRepository(DataContext context)
        {
            _context = context;
        }
        public List<Product> GetList()
        {
            return _context.ProductList.ToList();

        }
    }
}
