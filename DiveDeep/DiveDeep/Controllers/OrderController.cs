using Microsoft.AspNetCore.Mvc;

namespace DiveDeep.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Kurv()
        {
            return View();
        }
    }
}
