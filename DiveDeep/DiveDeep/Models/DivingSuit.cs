namespace DiveDeep.Models
{
    public record DivingSuitSpecs
    {
        public string Model { get; set; }
        public Size Size { get; set; }
        public SuitType SuitType { get; set; }
        public Gender Gender { get; set; }
        public double? ThicknessInMm { get; set; }

    }
}
