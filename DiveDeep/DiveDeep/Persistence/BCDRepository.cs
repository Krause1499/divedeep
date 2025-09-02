using DiveDeep.Models;

namespace DiveDeep.Persistence
{
    public static class BCDRepository
    {
        private static List<BCD> BCDs = new List<BCD>
        {
            new BCD {Brand = "Scubapro", Model = "Navigator Lite BCD", Size = Size.M, Price = 125},
            new BCD {Brand = "Scubapro", Model = "BCD Glide", Size = Size.M, Price = 140},
            new BCD {Brand = "Scubapro", Model = "BCD Hydros Pro", Size = Size.M, Price = 200},
            new BCD {Brand = "Seac", Model = "BCD Modular", Size = Size.M, Price = 145}

            // Der skal egentligt være flere forskellige størrelser
        };
        public static List<BCD> GetAllBCDs()
        {
            return BCDs;
        }

    }
}
