using DiveDeep.Persistence;
using DiveDeep.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DiveDeep.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductRepository _products;

        public ProductsController(IProductRepository products)
        {
            _products = products;
        }

        public IActionResult ProductInfo(int id)
        {
            var product = _products.GetByID(id);
            var pdvm = new ProductDetailsViewModel
            {
                Product = product
            };
            return View(pdvm);
        }
    }
}