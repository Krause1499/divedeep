using DiveDeep.Models;
using DiveDeep.Persistence;
using DiveDeep.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DiveDeep.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductRepository _products;

        public ProductsController(IProductRepository products)
        {
            _products = products;
        }

        public IActionResult ProductInfo(int id)
        {
            var product = _products.GetByID(id);
            var pdvm = new ProductDetailsViewModel
            {
                Product = product
            };
            return View(pdvm);
        }

        public IActionResult Edit(int id)
        {
            var product = _products.GetByID(id);

            if (product == null)
            return NotFound();

            ViewBag.Action = "edit";

            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Action = "edit";
                return View(product);
            }

            _products.Update(product);

            return RedirectToAction("ProductInfo", product);
        }
    }
}