using DiveDeep.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace DiveDeep.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly IProductRepository _productRepository;

        public CategoriesController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult BCD()
        {
            var categories = _productRepository.GetAllProductsByType(Models.ProductType.BCD);
            return View(categories);
        }
        public IActionResult Dykkerdragter()
        {
            var categories = _productRepository.GetAllProductsByType(Models.ProductType.DivingSuit);
            return View(categories);
        }
        public IActionResult Tanke()
        {
            var categories = _productRepository.GetAllProductsByType(Models.ProductType.OxygenTank);
            return View(categories);
        }
        public IActionResult Regulatorsæt()
        {
            var categories = _productRepository.GetAllProductsByType(Models.ProductType.Regulator);
            return View(categories);
        }
        public IActionResult MaskerSnorkler()
        {
            var categories = _productRepository.GetAllProductsByType(Models.ProductType.Snorkel);
            return View(categories);
        }
        public IActionResult Finner()
        {
            var categories = _productRepository.GetAllProductsByType(Models.ProductType.Fins);
            return View(categories);
        }
        public IActionResult DykkerSæt()
        {
            var categories = _productRepository.GetAllProductsByType(Models.ProductType.DivingSet);
            return View(categories);
        }

        public IActionResult Kurv()
        {
            return View();
        }
    }
}
