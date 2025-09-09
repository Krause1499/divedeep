 namespace DiveDeep.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string FilePath { get; set; } = "~/Images/SnorkelPNG.webp";
        public string Brand { get; set; }
        public int Price { get; set; }
        public ProductType ProductType { get; set; }
    }
}
