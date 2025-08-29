namespace DiveDeep.Models
{
    public class DivingSuit : Category
    {
        public string Model { get; set; }
        public Size Size { get; set; }
        public SuitType Type { get; set; }
        public Gender Gender { get; set; }
        public double? Thickness { get; set; }

    }
}
