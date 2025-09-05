namespace DiveDeep.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string FilePath { get; set; } =  "/Images/divedeeplogoPNG.png";
        public string Brand { get; set; }
        public int Price { get; set; }
    }
}
