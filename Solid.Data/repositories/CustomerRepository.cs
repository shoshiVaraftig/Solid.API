using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solid.Core.Models;
using Solid.Core.Repositories;

namespace Solid.Data.repositories
{
    public class CustomerRepository:ICustomerRepository
    {
        private readonly DataContext _context;
        public CustomerRepository(DataContext context)
        {
            _context=context;
        }
        public List<Customer> GetList()
        {
            return _context.CustomerList.ToList();

        }
    }
}
