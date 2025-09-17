using Microsoft.AspNetCore.Mvc;
using DiveDeep.ViewModels;
using DiveDeep.Models;

namespace DiveDeep.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult ProductInfo(int id)
        {
            var product = Persistence.ProductRepository.GetByID(id);

            switch(product.ProductType)
            {
                case ProductType.BCD:
                    break;
            }

            var pvm = new ProductViewModel
            {
                product.
            };

            return View(product);
        }
    }
}