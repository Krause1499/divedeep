using DiveDeep.Persistence;
using DiveDeep.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DiveDeep.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult ProductInfo(int id)
        {
            var product = _productRepository.GetByID(id);
            var pdvm = new ProductDetailsViewModel
            {
                Product = product
            };
            return View(pdvm);
        }
    }
}