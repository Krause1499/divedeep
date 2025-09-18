using DiveDeep.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DiveDeep.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult ProductInfo(int id)
        {
            var product = Persistence.ProductRepository.GetByID(id);
            var pdvm = new ProductDetailsViewModel
            {
                Product = product
            };
            return View(pdvm);
        }
    }
}