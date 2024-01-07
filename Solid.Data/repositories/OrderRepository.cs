using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solid.Core.Models;
using Solid.Core.Repositories;

namespace Solid.Data.repositories
{
    public class OrderRepository:IOrderRepository
    {
        private readonly DataContext _context;
        public OrderRepository(DataContext context)
        {
            _context = context;
        }
        public List<Order> GetList()
        {
            return _context.OrderList.ToList();

        }
    }
}
