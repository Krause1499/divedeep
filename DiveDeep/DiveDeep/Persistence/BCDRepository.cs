using DiveDeep.Models;

namespace DiveDeep.Persistence
{
    public static class BCDRepository
    {
        private static List<BCD> BCDs = new List<BCD>
        {
            new BCD {Id = 1, Brand = "Scubapro", Model = "Navigator Lite BCD", Size = Size.M, Price = 125},
            new BCD {Id = 2, Brand = "Scubapro", Model = "BCD Glide", Size = Size.M, Price = 140},
            new BCD {Id = 3, Brand = "Scubapro", Model = "BCD Hydros Pro", Size = Size.M, Price = 200},
            new BCD {Id = 4, Brand = "Seac", Model = "BCD Modular", Size = Size.M, Price = 145}

            // Der skal egentligt være flere forskellige størrelser
        };
        public static List<BCD> GetAllBCDs()
        {
            return BCDs;
        }

        public static object GetByID(int id)
        {
            return BCDs.FirstOrDefault(x => x.Id == id);
        }

    }
}
