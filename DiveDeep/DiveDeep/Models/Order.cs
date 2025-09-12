namespace DiveDeep.Models
{
    public class Order
    {
        public List<OrderItem> Items { get; set; }
        public int TotalPrice { get; set; }
    }
}
