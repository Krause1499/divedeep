namespace DiveDeep.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int TotalPrice { get; set; }
        public bool IsConfirmed { get; set; } = false;

        public ApplicationUser? User { get; set; }
        public string? UserId { get; set; }

        public ICollection<OrderItem> Items { get; set; }
    }
}
