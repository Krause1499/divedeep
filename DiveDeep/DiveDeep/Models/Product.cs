 namespace DiveDeep.Models
{
    public class Product
    {
        public int Id { get; set; }
        public ProductType ProductType { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public string FilePath { get; set; }
        public int DailyPrice { get; set; }

        public BCDSpecs? BCD {  get; set; }
        public DivingSuitSpecs? DivingSuit { get; set; }
        public FinsSpecs? Fins { get; set; }
        public OxygenTankSpecs? OxygenTank { get; set; }
        public RegulatorSpecs? Regulator { get; set; }
        public MaskSnorkelSpecs? MaskSnorkel { get; set; }
    }
}
