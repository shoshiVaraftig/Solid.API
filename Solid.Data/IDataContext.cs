using Solid.Core.Models;

namespace project_api
{
    public interface IDataContext
    {
        public interface IDataContext
        {
            public List<Product> ProductList { get; set; }
            public List<Customer> CustomerList { get; set; }
            public List<Order> OrderList { get; set; }
        }
        //public IDataContext()
        //{
        //    //מה שמים פה בקונסטרקטור?
        //}
    }
}
