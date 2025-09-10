using System.Diagnostics;
using DiveDeep.Models;
using Microsoft.AspNetCore.Mvc;

namespace DiveDeep.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Om()
        {
            return View();
        }

        public IActionResult FAQ()
        {
            return View();
        }

        public IActionResult ForsendelseOgRetur()
        {
            return View();
        }

        public IActionResult Job()
        {
            return View();
        }

        public IActionResult Anmeldelser()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
