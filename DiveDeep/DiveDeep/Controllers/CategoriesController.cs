using Microsoft.AspNetCore.Mvc;

namespace DiveDeep.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult BCD()
        {
            var categories = Persistence.CategoryRepository.GetAllProducts();
            return View(categories);
        }
        public IActionResult Dykkerdragter()
        {
            return View();
        }
        public IActionResult Tanke()
        {
            return View();
        }
        public IActionResult Regulatorsæt()
        {
            return View();
        }
        public IActionResult MaskerSnorkler()
        {
            return View();
        }
        public IActionResult Finner()
        {
            return View();
        }
    }
}
