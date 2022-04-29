namespace StoreFront.Models
{
    public class Response
    {
        public int StatusCode { get; set; }
        public string StatusDescription { get; set; }
        public List<Customer> Customers { get; set; } = new();
        public List<Order> Orders { get; set; } = new();
        public List<Product> Products { get; set; } = new();
        public List<ShoppingCart> ShoppingCarts { get; set; } = new();
    }
}
