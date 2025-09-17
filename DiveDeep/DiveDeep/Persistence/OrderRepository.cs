using DiveDeep.Models;

namespace DiveDeep.Persistence
{
    public class OrderRepository
    {
        public static List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public static void Add(OrderItem item)
        {
            Items.Add(item);
        }
    }
}
