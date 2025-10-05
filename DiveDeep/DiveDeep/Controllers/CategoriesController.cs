using DiveDeep.Data;
using DiveDeep.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace DiveDeep.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly IProductRepository _products;

        public CategoriesController(IProductRepository products)
        {
            _products = products;
        }

        public IActionResult BCD()
        {
            var categories = _products.GetAllProductsByType(Models.ProductType.BCD);
            return View(categories);
        }
        public IActionResult Dykkerdragter()
        {
            var categories = _products.GetAllProductsByType(Models.ProductType.DivingSuit);
            return View(categories);
        }
        public IActionResult Tanke()
        {
            var categories = _products.GetAllProductsByType(Models.ProductType.OxygenTank);
            return View(categories);
        }
        public IActionResult Regulatorsæt()
        {
            var categories = _products.GetAllProductsByType(Models.ProductType.Regulator);
            return View(categories);
        }
        public IActionResult MaskerSnorkler()
        {
            var categories = _products.GetAllProductsByType(Models.ProductType.Snorkel);
            return View(categories);
        }
        public IActionResult Finner()
        {
            var categories = _products.GetAllProductsByType(Models.ProductType.Fins);
            return View(categories);
        }
        public IActionResult DykkerSæt()
        {
            var categories = _products.GetAllProductsByType(Models.ProductType.DivingSet);
            return View(categories);
        }

        public IActionResult Kurv()
        {
            return View();
        }
    }
}
