using DiveDeep.Data;
using DiveDeep.Models;

namespace DiveDeep.Persistence
{
    public class ProductRepository : IProductRepository
    {
        private readonly DiveDeepContext _context;

        public ProductRepository(DiveDeepContext diveDeepContext)
        {
            _context = diveDeepContext;
        }

        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllProductsByType(ProductType product)
        {
            var Products = _context.Product.ToList();
            List<Product> products = Products
                .Where(p => p.ProductType == product)
                .OrderBy(p => p.Brand) // eller hvad du vil sortere på
                .ToList();

            return products;
        }

        public Product? GetByID(int? id)
        {
           if (id == null)
            {
                return null;
            }
            var product = _context.Product
                .FirstOrDefault(p => p.Id == id);
            return product;
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}