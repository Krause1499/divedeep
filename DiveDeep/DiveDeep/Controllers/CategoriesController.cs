using Microsoft.AspNetCore.Mvc;

namespace DiveDeep.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult BCD()
        {
            var categories = Persistence.ProductRepository.GetAllProductsByType(Models.ProductType.BCD);
            return View(categories);
        }
        public IActionResult Dykkerdragter()
        {
            var categories = Persistence.ProductRepository.GetAllProductsByType(Models.ProductType.DivingSuit);
            return View(categories);
        }
        public IActionResult Tanke()
        {
            var categories = Persistence.ProductRepository.GetAllProductsByType(Models.ProductType.OxygenTank);
            return View(categories);
        }
        public IActionResult Regulatorsæt()
        {
            var categories = Persistence.ProductRepository.GetAllProductsByType(Models.ProductType.Regulator);
            return View(categories);
        }
        public IActionResult MaskerSnorkler()
        {
            var categories = Persistence.ProductRepository.GetAllProductsByType(Models.ProductType.Snorkel);
            return View(categories);
        }
        public IActionResult Finner()
        {
            var categories = Persistence.ProductRepository.GetAllProductsByType(Models.ProductType.Fin);
            return View(categories);
        }
        public IActionResult DivingSet()
        {
            var categories = Persistence.ProductRepository.GetAllProductsByType(Models.ProductType.DivingSet);
            return View(categories);
        }
        public IActionResult SnorkelSet()
        {
            var categories = Persistence.ProductRepository.GetAllProductsByType(Models.ProductType.SnorkelSet);
            return View(categories);
        }
    }
}
