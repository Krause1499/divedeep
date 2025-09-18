 namespace DiveDeep.Models
{
    public class Product
    {
        public int? Id { get; set; }
        public ProductType? ProductType { get; set; }
        public string? Brand { get; set; }
        public string? Description { get; set; }
        public string? FilePath { get; set; }
        public int DailyPrice { get; set; }

        public BCDSpecs BCD {  get; set; } = new BCDSpecs();
        public DivingSuitSpecs DivingSuit { get; set; } = new DivingSuitSpecs();
        public FinsSpecs Fins { get; set; } = new FinsSpecs();
        public OxygenTankSpecs OxygenTank { get; set; } = new OxygenTankSpecs();
        public RegulatorSpecs Regulator { get; set; } = new RegulatorSpecs();
        public MaskSnorkelSpecs MaskSnorkel { get; set; } = new MaskSnorkelSpecs();
    }
}
