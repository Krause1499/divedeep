using DiveDeep.Models;

namespace DiveDeep.Persistence
{
    public static class SnorkelRepository
    {

        private static List<Snorkel> Snorkels = new List<Snorkel>
        {
            new Snorkel {Brand = "Scubapro", Model = "Ghost", Price = 50},
            new Snorkel {Brand = "Scubapro", Model = "D-Mask", Price = 60},
            new Snorkel {Brand = "Scubapro", Model = "Spectra Mini", Price = 50},
            new Snorkel {Brand = "Scubapro", Model = "Crystal VU", Price = 75},
            new Snorkel {Brand = "Scubapro", Model = "Scout Kontrast", Price = 75},
            new Snorkel {Brand = "Scubapro", Model = "Scout Enhance", Price = 75},
            new Snorkel {Brand = "Scubapro", Model = "Element", Price = 75}

        };
        public static List<Snorkel> GetAllSnorkels()
        {
            return Snorkels;
        }
        public static Snorkel? GetByID(int id)
        {
            return Snorkels.FirstOrDefault(x => x.Id == id);
        }
    }
}
