using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public int CustomerId { get; set; }
    }
}
