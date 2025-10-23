using DiveDeep.Data;
using DiveDeep.Models;
using Microsoft.EntityFrameworkCore;

namespace DiveDeep.Persistence
{
    public class ProductRepository : IProductRepository
    {
        private readonly DiveDeepContext _context;
        public ProductRepository(DiveDeepContext context)
        {
            _context = context;
        }

        public List<Product> GetAll()
        {
            return _context.Products
                .OrderBy(p => p.ProductType)
                .ToList();
        }

        public List<Product> GetAllProductsByType(ProductType product)
        {
            return _context.Products
                .Where(p => p.ProductType == product)
                .OrderBy(p => p.Brand) // eller hvad du vil sortere på
                .ToList();
        }

        public Product? GetByID(int id)
        {
            return _context.Products
                .FirstOrDefault(x => x.Id == id);
        }

        public void Update(Product product)
        {
            var entityToUpdate = _context.Products.FirstOrDefault(p => p.Id == product.Id);
            if (entityToUpdate == null)
                return;

            entityToUpdate.Brand = product.Brand;
            entityToUpdate.Description = product.Description;
            entityToUpdate.DailyPrice = product.DailyPrice;

            if (entityToUpdate.ProductType == ProductType.BCD)
            entityToUpdate.BCD.Model = product.BCD.Model;

            if (entityToUpdate.ProductType == ProductType.DivingSuit)
            {
                entityToUpdate.DivingSuit.Model = product.DivingSuit.Model;
                entityToUpdate.DivingSuit.ThicknessInMm = product.DivingSuit.ThicknessInMm;
            }

            if (entityToUpdate.ProductType == ProductType.Fins)
            entityToUpdate.Fins.Model = product.Fins.Model;

            if (entityToUpdate.ProductType == ProductType.Snorkel)
            entityToUpdate.MaskSnorkel.Model = product.MaskSnorkel.Model;

            if (entityToUpdate.ProductType == ProductType.OxygenTank)
            entityToUpdate.OxygenTank.VolumeInL = product.OxygenTank.VolumeInL;

            if (entityToUpdate.ProductType == ProductType.Regulator)
            {
                entityToUpdate.Regulator.StageOne = product.Regulator.StageOne;
                entityToUpdate.Regulator.StageTwo = product.Regulator.StageTwo;
                entityToUpdate.Regulator.Octopus = product.Regulator.Octopus;
            }

            _context.SaveChanges();
        }
    }
}