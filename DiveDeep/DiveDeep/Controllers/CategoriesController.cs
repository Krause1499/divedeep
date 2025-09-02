using Microsoft.AspNetCore.Mvc;

namespace DiveDeep.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult BCD()
        {
            var categories = Persistence.BCDRepository.GetAllBCDs();
            return View(categories);
        }
        public IActionResult Dykkerdragter()
        {
            var categories = Persistence.DivingSuitRepository.GetAllDivingSuits();
            return View(categories);
        }
        public IActionResult Tanke()
        {
            var categories = Persistence.OxygenTankRepository.GetAllOxygenTanks();
            return View(categories);
        }
        public IActionResult Regulatorsæt()
        {
            var categories = Persistence.RegulatorRepository.GetAllRegulators();
            return View(categories);
        }
        public IActionResult MaskerSnorkler()
        {
            var categories = Persistence.SnorkelRepository.GetAllSnorkels();
            return View(categories);
        }
        public IActionResult Finner()
        {
            var categories = Persistence.FinRepository.GetAllFins();
            return View(categories);
        }
    }
}
