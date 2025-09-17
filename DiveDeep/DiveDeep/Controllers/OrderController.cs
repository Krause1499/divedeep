using DiveDeep.Models;
using DiveDeep.Persistence;
using DiveDeep.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;

namespace DiveDeep.Controllers
{
    public class OrderController : Controller
    {
        //public IActionResult Add(int id, DateOnly? startDate, DateOnly? endDate, Size size = Size.M, Gender gender = Gender.Herre)
        //{
        //    var product = ProductRepository.Products.FirstOrDefault(p => p.Id == id);
        //    if (product is null) return NotFound();

        //    // Lav et snapshot (OrderItem) ud fra produktet
        //    var item = new OrderItem
        //    {
        //        Id = product.Id,
        //        FilePath = product.FilePath,
        //        Brand = product.Brand,
        //        Price = product.Price,
        //        ProductType = product.ProductType,
        //        StartDate = startDate,
        //        EndDate = endDate,
        //        Size = size,
        //        Gender = gender
        //    };

        //    // Hvis produktet faktisk er en BCD, kopier ekstra felter
        //    if (product is OxygenTank ot)
        //    {
        //        item.Volume = ot.Volume;
        //    }
        //    Order.Items.Add(item);

        //    // Gå til oversigten
        //    return Redirect(Request.Headers["Referer"].ToString());
        //}

        [HttpPost]
        public IActionResult Add(ProductViewModel pvm)
        {
            OrderItem item = new OrderItem
            {
                Id = pvm.Category.Id,
                FilePath = pvm.Category.FilePath,
                Brand = pvm.Category.Brand,
                Price = pvm.Category.Price,
                ProductType = pvm.Category.ProductType,
                StartDate = pvm.Category.StartDate,
                EndDate = pvm.Category.EndDate,
                Size = pvm.BCD.Size,
                Model = pvm.BCD.Model
            };

            OrderRepository.Add(item);
            return Redirect(Request.Headers["Referer"].ToString());
        }

        public IActionResult Kurv()
        {
            return View();
        }
    }
}
