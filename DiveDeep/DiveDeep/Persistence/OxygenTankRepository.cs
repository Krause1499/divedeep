using DiveDeep.Models;

namespace DiveDeep.Persistence
{
    public class OxygenTankRepository
    {

        private static List<OxygenTank> OxygenTanks = new List<OxygenTank>
        {
            new OxygenTank {Brand = "Scubapro", Volume = 5, Price = 150},
            new OxygenTank {Brand = "Scubapro", Volume = 10, Price = 160},
            new OxygenTank {Brand = "Scubapro", Volume = 12, Price = 170},
            new OxygenTank {Brand = "Scubapro", Volume = 15, Price = 180}

        };
        public static List<OxygenTank> GetAllOxygenTanks()
        {
            return OxygenTanks;
        }

    }
}
