namespace DiveDeep.Models
{
    public class Order
    {
        public static List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public int TotalPrice { get; set; }
    }
}
