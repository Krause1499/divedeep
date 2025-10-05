namespace DiveDeep.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int TotalPrice { get; set; }

        public ICollection<OrderItem> Items { get; set; }
    }
}
