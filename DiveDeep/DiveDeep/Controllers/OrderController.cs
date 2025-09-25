using DiveDeep.Models;
using DiveDeep.Persistence;
using DiveDeep.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace DiveDeep.Controllers
{
    public class OrderController : Controller
    {
        private readonly IProductRepository _productRepository;

        public OrderController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpPost]
        public IActionResult Add(ProductDetailsViewModel pdvm)
        {
            var product = _productRepository.GetByID(pdvm.Product.Id);
            if (product is null) return NotFound();

            if (product.ProductType != ProductType.BCD)
            {
                ModelState.Remove("Product.BCD.Size");
            }

            if (product.ProductType != ProductType.Fins)
            {
                ModelState.Remove("Product.Fins.Size");
            }

            if (product.ProductType != ProductType.DivingSuit)
            {
                ModelState.Remove("Product.DivingSuit.Size");
                ModelState.Remove("Product.DivingSuit.Gender");
            }

                if (ModelState.IsValid)
                {
                    // Lav et snapshot (OrderItem) ud fra produktet
                    var item = new OrderItem
                    {
                        Id = product.Id,
                        FilePath = product.FilePath,
                        Brand = product.Brand,
                        Price = product.DailyPrice,
                        ProductType = product.ProductType,
                        StartDate = pdvm.StartDate,
                        EndDate = pdvm.EndDate
                    };

                if (product.ProductType is ProductType.BCD)
                {
                    item.Size = pdvm.Product.BCD.Size;
                }

                if (product.ProductType is ProductType.DivingSuit)
                {
                    item.Size = pdvm.Product.DivingSuit.Size;
                    item.Gender = pdvm.Product.DivingSuit.Gender;
                }

                if (product.ProductType is ProductType.Fins)
                {
                    item.Size = pdvm.Product.Fins.Size;
                }

                Order.Items.Add(item);
                pdvm.Product = product;
                return View("~/Views/Products/ProductInfo.cshtml", pdvm);
                }

            pdvm.Product = product;
            // Gå til oversigten
            return View("~/Views/Products/ProductInfo.cshtml", pdvm);
        }
        public IActionResult Kurv()
        {
            return View();
        }
    }
}
