using DiveDeep.Models;

namespace DiveDeep.ViewModels
{
    public class DykkerSæt
    {
        public BCD BCD { get; set; }
        public DivingSuit DivingSuit { get; set; }
        public Fin Fin { get; set; }
        public OxygenTank OxygenTank { get; set; }
        public Regulator Regulator { get; set; }
        public Snorkel Snorkel { get; set; }
        // hvis man gør dette så denne måde så tror jeg at man kun kan sætte alle dem der har id=1 til at være sammen
    }
}
