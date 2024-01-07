namespace Solid.Core.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int Product_id { get; set; }
        public int Num { get; set; }
        public int cust_id { get; set; }

        public List<Product>? products { get; set; }

        public int product_id { get; set; }
    }
}
