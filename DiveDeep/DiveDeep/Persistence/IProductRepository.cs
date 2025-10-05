using DiveDeep.Models;

namespace DiveDeep.Persistence
{
    public interface IProductRepository
    {
        List<Product> GetAll();

        List<Product> GetAllProductsByType(ProductType product);

        Product? GetByID(int id);
    }
}
