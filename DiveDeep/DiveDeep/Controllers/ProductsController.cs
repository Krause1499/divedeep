using Microsoft.AspNetCore.Mvc;

namespace DiveDeep.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult ProductInfoBCD(int id)
        {
            var product = Persistence.BCDRepository.GetByID(id);
            return View(product);
        }

        public IActionResult ProductInfoDivingSuit(int id)
        {
            var product = Persistence.DivingSuitRepository.GetByID(id);
            return View(product);
        }

        public IActionResult ProductInfoFinner(int id)
        {
            var product = Persistence.BCDRepository.GetByID(id);
            return View(product);
        }

        public IActionResult ProductInfoTanke(int id)
        {
            var product = Persistence.BCDRepository.GetByID(id);
            return View(product);
        }

        public IActionResult ProductInfoRegulatorsæt(int id)
        {
            var product = Persistence.BCDRepository.GetByID(id);
            return View(product);
        }

        public IActionResult ProductInfoMaskerSnorkler(int id)
        {
            var product = Persistence.BCDRepository.GetByID(id);
            return View(product);
        }
    }
}