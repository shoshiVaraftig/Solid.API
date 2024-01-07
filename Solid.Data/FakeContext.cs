
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using Solid.Core.Models;

namespace project_api
{
    public class FakeContext:IDataContext
    {

        public List<Product> ProductList { get; set; }
        public List<Customer> CustomerList { get; set; }
        public List<Order> OrderList { get; set; }
        public FakeContext()
        {

            ProductList = new List<Product> { new Product { } };
            CustomerList = new List<Customer> { new Customer { } };
            OrderList = new List<Order> { new Order { Id = 1, Product_id = 3, Num = 2, cust_id = 5 } };
        }
    }
}
