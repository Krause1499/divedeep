using Microsoft.AspNetCore.Mvc;

namespace DiveDeep.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult ProductInfo(int id)
        {
            var product = Persistence.ProductRepository.GetByID(id);
            return View(product);
        }
    }
}