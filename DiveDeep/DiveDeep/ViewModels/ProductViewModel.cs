using DiveDeep.Models;

namespace DiveDeep.ViewModels
{
    public class ProductViewModel
    {
        public Category Category { get; set; }
        public BCD BCD { get; set; }
        public DivingSuit DivingSuit { get; set; }
        public Fin Fin { get; set; }
        public OxygenTank OxygenTank { get; set; }
        public Regulator Regulator { get; set; }
        public Snorkel Snorkel { get; set; }
    }
}
