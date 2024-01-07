using Solid.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solid.Core.Repositories;
using Solid.Core.Services;
namespace Solid.Service.Services
{
    public class OrderService:IOrderService
    {
            private readonly IOrderRepository _orderRepository;
            public OrderService(IOrderRepository orderRepository)
            {
            _orderRepository = orderRepository;
            }
            public List<Order> GetAll()
            {
            return _orderRepository.GetList();
            }
       
    }
}
