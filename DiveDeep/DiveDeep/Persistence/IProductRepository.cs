using DiveDeep.Models;

namespace DiveDeep.Persistence
{
    public interface IProductRepository
    {
        void Add(Product product);
        void Delete(int id);
        List<Product> GetAllProductsByType(ProductType productType);
        Product GetByID(int? id);
        void Update(Product product);
    }
}
