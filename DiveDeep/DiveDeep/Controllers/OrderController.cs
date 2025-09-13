using DiveDeep.Models;
using DiveDeep.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace DiveDeep.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Add(int id, DateOnly? startDate, DateOnly? endDate)
        {
            var product = ProductRepository.Products.FirstOrDefault(p => p.Id == id);
            if (product is null) return NotFound();

            // Lav et snapshot (OrderItem) ud fra produktet
            var item = new OrderItem
            {
                Id = product.Id,
                FilePath = product.FilePath,
                Brand = product.Brand,
                Price = product.Price,
                ProductType = product.ProductType,
                StartDate = startDate,
                EndDate = endDate
            };

            // Hvis produktet faktisk er en BCD, kopier ekstra felter
            if (product is OxygenTank ot)
            {
                item.Volume = ot.Volume;
            }

            Order.Items.Add(item);

            // Gå til oversigten
            return Redirect(Request.Headers["Referer"].ToString());
        }
        public IActionResult Kurv()
        {
            return View();
        }
    }
}
