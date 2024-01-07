using Microsoft.AspNetCore.Mvc;
using Solid.Core.Models;
using Solid.Core.Services;
using Solid.API.Controllers;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Solid.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {



        //private static DataContext _context = new DataContext();

        private readonly IOrderService _orderService;
        public OrdersController(IOrderService orderService)
        {
            _orderService=orderService;
        }


        // GET: api/<OrdersController>
        [HttpGet]
        public IEnumerable<Order> Get()
        {
            return _orderService.GetAll();
        }

        // GET api/<OrdersController>/5
        [HttpGet("{id}")]
        public Order Get(int id)
        {
            Order o = _orderService.GetAll().Find(o => o.Id == id);
            return o;
        }

        // POST api/<OrdersController>
        [HttpPost]
        public void Post([FromBody] Order o1)
        {
            int index = 0, n = o1.Num;
            for (int i = 0; i < _orderService.GetAll().Count; i++)
            {
                if (_orderService.GetAll()[i].Id == o1.Id)
                {
                    if (_context.GetAll()[i].Qty==o1.Num)
                    {
                        index = i;
                        _orderService.GetAll().Add(new Order {
                            Id = _context.ProductList.Count + 1,
                            Num=o1.Num,cust_id=o1.cust_id,
                            Product_id=o1.Product_id});

                     _context.ProductList[index].Qty -= o1.Num;
                       
                        return ;
                    }
                }
            }
            Console.WriteLine("you can't buy that");
        }

        // PUT api/<OrdersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Order updatedOrder)
        {
            var existingOrder = _orderService.GetAll().FirstOrDefault(o => o.Id == id);

            if (existingOrder != null)
            {
                // Update the order properties with the values from updatedOrder
                existingOrder.Num = updatedOrder.Num;
                existingOrder.cust_id = updatedOrder.cust_id;
                existingOrder.Product_id = updatedOrder.Product_id;

                // Find the corresponding product in the ProductList
                var product = _orderService.GetAll().FirstOrDefault(p => p.Id == existingOrder.Product_id);

                if (product != null)
                {
                    // Calculate the difference in quantity
                    int quantityDifference = existingOrder.Num - updatedOrder.Num;

                    // Update the quantity of the product in the ProductList
                    product.Qty += quantityDifference;
                }
                else
                {
                    Console.WriteLine("Product not found");
                }
            }
            else
            {
                Console.WriteLine("Order not found");
            }
        }

        // DELETE api/<OrdersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            //int n = o1.Num;
            for (int i = 0; i < _context.ProductList.Count; i++)
            {
                if (_context.ProductList[i].Id == id)
                {
                    _context.ProductList.Remove(_context.ProductList[i]);
                }
            }
        }

    }
}
