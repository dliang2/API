using System.ComponentModel.DataAnnotations;

namespace StoreFront.Models
{
    public class ShoppingCart
    {
        [Key]
        public int ItemId { get; set; }
        [Key]
        public Order Order { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        
    }
}
