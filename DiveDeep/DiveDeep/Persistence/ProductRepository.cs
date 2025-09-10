using DiveDeep.Models;

namespace DiveDeep.Persistence
{
    public static class ProductRepository
    {
        public static List<Category> Products = new List<Category>
        {
            new BCD {Id = 1, ProductType = ProductType.BCD, Brand = "Scubapro", Model = "Navigator Lite BCD", Size = Size.M, Price = 125},
            new BCD {Id = 2, ProductType = ProductType.BCD, Brand = "Scubapro", Model = "BCD Glide", Size = Size.M, Price = 140},
            new BCD {Id = 3, ProductType = ProductType.BCD, Brand = "Scubapro", Model = "BCD Hydros Pro", Size = Size.M, Price = 200},
            new BCD {Id = 4, ProductType = ProductType.BCD, Brand = "Seac", Model = "BCD Modular", Size = Size.M, Price = 145},
            new DivingSuit {Id = 5, ProductType = ProductType.DivingSuit,  Brand = "Fourth Element", Model = "Proteus", Size = Size.M, Type = SuitType.Våddragt, Gender = Gender.Herre, Thickness = 5, Price = 120},
            new DivingSuit {Id = 6, ProductType = ProductType.DivingSuit, Brand = "Scubapro", Model = "Exodry 4.0", Size = Size.M, Type = SuitType.Tørdragt, Gender = Gender.Herre, Price = 300},
            new DivingSuit {Id = 7, ProductType = ProductType.DivingSuit, Brand = "Waterproof", Model = "D7 Evo", Size = Size.M, Type = SuitType.Tørdragt, Gender = Gender.Herre, Price = 320},
            new DivingSuit {Id = 8, ProductType = ProductType.DivingSuit, Brand = "Santi", Model = "E.Lite Plus", Size = Size.M, Type = SuitType.Tørdragt, Gender = Gender.Herre, Price = 350},
            new Regulator {Id = 9, ProductType = ProductType.Regulator, Brand = "Scubapro", StageOne = "MK25EVO", StageTwo = "S600", Octopus = "R105" , Price = 125},
            new Regulator {Id = 10, ProductType = ProductType.Regulator, Brand = "Scubapro", StageOne = "MK17EVO", StageTwo = "C370", Octopus = "R095" , Price = 100},
            new Regulator {Id = 11, ProductType = ProductType.Regulator, Brand = "Scubapro", StageOne = "MK25EVO BT", StageTwo = "A700 Carbon BT", Octopus = "S270" , Price = 150},
            new OxygenTank {Id = 12, ProductType = ProductType.OxygenTank, Brand = "Scubapro", Volume = 5, Price = 150},
            new OxygenTank {Id = 13, ProductType = ProductType.OxygenTank, Brand = "Scubapro", Volume = 10, Price = 160},
            new OxygenTank {Id = 14, ProductType = ProductType.OxygenTank, Brand = "Scubapro", Volume = 12, Price = 170},
            new OxygenTank {Id = 15, ProductType = ProductType.OxygenTank, Brand = "Scubapro", Volume = 15, Price = 180},
            new Fin {Id = 16, ProductType = ProductType.Fin, Brand = "Scubapro", Model = "Jet Fin", Size = Size.M, Price = 50},
            new Fin {Id = 17, ProductType = ProductType.Fin, Brand = "Scubapro", Model = "GO Travel", Size = Size.M, Price = 50},
            new Fin {Id = 18, ProductType = ProductType.Fin, Brand = "Scubapro", Model = "Seawing Supernova", Size = Size.M, Price = 60},
            new Fin {Id = 19, ProductType = ProductType.Fin, Brand = "Seac", Model = "Propulsion", Size = Size.M, Price = 50},
            new Fin {Id = 20, ProductType = ProductType.Fin, Brand = "Seac", Model = "ALA", Size = Size.M, Price = 50},
            new Fin {Id = 21, ProductType = ProductType.Fin, Brand = "Fourth Element", Model = "Tech", Size = Size.M, Price = 75},
            new Fin {Id = 22, ProductType = ProductType.Fin, Brand = "Fourth Element", Model = "Rec Fin", Size = Size.M, Price = 80},
            new Snorkel {Id = 23, ProductType = ProductType.Snorkel, Brand = "Scubapro", Model = "Ghost", Price = 50},
            new Snorkel {Id = 24, ProductType = ProductType.Snorkel, Brand = "Scubapro", Model = "D-Mask", Price = 60},
            new Snorkel {Id = 25, ProductType = ProductType.Snorkel, Brand = "Scubapro", Model = "Spectra Mini", Price = 50},
            new Snorkel {Id = 26, ProductType = ProductType.Snorkel, Brand = "Scubapro", Model = "Crystal VU", Price = 75},
            new Snorkel {Id = 27, ProductType = ProductType.Snorkel, Brand = "Scubapro", Model = "Scout Kontrast", Price = 75},
            new Snorkel {Id = 28, ProductType = ProductType.Snorkel, Brand = "Scubapro", Model = "Scout Enhance", Price = 75},
            new Snorkel {Id = 29, ProductType = ProductType.Snorkel, Brand = "Scubapro", Model = "Element", Price = 75},
            new DivingSet {Id = 30, ProductType = ProductType.DivingSet, Brand = "Scubapro", Model = "something", Price = 100 },
            new DivingSet {Id = 31, ProductType = ProductType.SnorkelSet, Brand = "Scubapro", Model = "something", Price = 100 }

        };

        public static List<object> GetAllProductsByType(ProductType product)
        {
            List<object> products = Products
                .Where(p => p.ProductType == product)
                .OrderBy(p => p.Brand) // eller hvad du vil sortere på
                .Cast<object>()
                .ToList();

            return products;
        }

        public static object? GetByID(int id)
        {
            return Products.FirstOrDefault(x => x.Id == id);
        }
    }
}