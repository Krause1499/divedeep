namespace DiveDeep.Models
{
    public class InventoryUnit
    {
        public int Id { get; set; }

        public Size Size { get; set; }
        public Gender Gender { get; set; }

        // Fx reference til visningsprodukt (billede/brand/pris) hvis du vil
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }

}
