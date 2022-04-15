using System.Data;

namespace StoreFront.Models
{
    public class Order
    {
        
        public int OrderId { get; set; }
        public Customer Customer { get; set; }
        public string OrderStatus { get; set; }
        public DateTime OrderDate { get; set; }

    }
}
