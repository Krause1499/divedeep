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
    }
}