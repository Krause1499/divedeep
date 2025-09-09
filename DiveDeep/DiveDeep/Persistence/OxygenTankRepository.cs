using DiveDeep.Models;

namespace DiveDeep.Persistence
{
    public static class OxygenTankRepository
    {

        private static List<OxygenTank> OxygenTanks = new List<OxygenTank>
        {
            new OxygenTank {Id = 1, Brand = "Scubapro", Volume = 5, Price = 150},
            new OxygenTank {Id = 2, Brand = "Scubapro", Volume = 10, Price = 160},
            new OxygenTank {Id = 3, Brand = "Scubapro", Volume = 12, Price = 170},
            new OxygenTank {Id = 4, Brand = "Scubapro", Volume = 15, Price = 180}

        };
        public static List<OxygenTank> GetAllOxygenTanks()
        {
            return OxygenTanks;
        }
        public static OxygenTank? GetByID(int id)
        {
            return OxygenTanks.FirstOrDefault(x => x.Id == id);
        }
    }
}
