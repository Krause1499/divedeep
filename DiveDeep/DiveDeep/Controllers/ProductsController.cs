using Microsoft.AspNetCore.Mvc;

namespace DiveDeep.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Products(int id)
        {
            var product = Persistence.ProductRepository.GetByID(id);
            return View(product);
        }

        public IActionResult ProductInfoDivingSuit(int id)
        {
            var product = Persistence.DivingSuitRepository.GetByID(id);
            return View(product);
        }

        public IActionResult ProductInfoFin(int id)
        {
            var product = Persistence.FinRepository.GetByID(id);
            return View(product);
        }

        public IActionResult ProductInfoOxygenTank(int id)
        {
            var product = Persistence.OxygenTankRepository.GetByID(id);
            return View(product);
        }

        public IActionResult ProductInfoRegulator(int id)
        {
            var product = Persistence.RegulatorRepository.GetByID(id);
            return View(product);
        }

        public IActionResult ProductInfoSnorkel(int id)
        {
            var product = Persistence.SnorkelRepository.GetByID(id);
            return View(product);
        }
    }
}