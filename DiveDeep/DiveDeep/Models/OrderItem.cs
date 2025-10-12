namespace DiveDeep.Models
{
    public class OrderItem
    {
        public int? Id { get; set; }
        public string? FilePath { get; set; }
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public Size? Size { get; set; }
        public SuitType? Type { get; set; }
        public Gender? Gender { get; set; }
        public int? Volume { get; set; }
        public string? StageOne { get; set; }
        public string? StageTwo { get; set; }
        public string? Octopus { get; set; }
        public double? Thickness { get; set; }
        public int Price { get; set; }
        public ProductType? ProductType { get; set; }
        public DateOnly? StartDate { get; set; }
        public DateOnly? EndDate { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }

        public int InventoryUnitId { get; set; }
        public InventoryUnit InventoryUnit { get; set; }
    }
}
