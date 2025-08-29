using DiveDeep.Models;

namespace DiveDeep.Persistence
{
    public static class CategoryRepository
    {
        private static List<Category> products = new List<Category>
        {
            new OxygenTank { Id = 1, Brand = "Standard Tank", Volume = 12, Price = 100 },
            new Regulator { Id = 2, Brand = "Pro Regulator", StageOne = "Balanced", StageTwo = "Adjustable", Octopus = "Included", Price = 125},
            new Snorkel { Id = 3, Brand = "Basic Snorkel", Model = "AquaLite", Price = 300},
            new Fin { Id = 4, Brand = "Diving Fins", Model = "WaveMaster", Size = Size.M, Price = 100}
        };

        public static List<Category> GetAllProducts()
        {
            return products;
        }
    }
}
