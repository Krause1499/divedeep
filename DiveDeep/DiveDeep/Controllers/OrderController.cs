using DiveDeep.Models;
using DiveDeep.Persistence;
using DiveDeep.Services;
using DiveDeep.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Infrastructure;
using SQLitePCL;

namespace DiveDeep.Controllers
{
    public class OrderController : Controller
    {
        private readonly IProductRepository _products;
        private readonly IOrderService _order;
        private readonly UserManager<ApplicationUser> _user;

        public OrderController(IProductRepository products, IOrderService order, UserManager<ApplicationUser> user)
        {
            _products = products;
            _order = order;
            _user = user;
        }

        public IActionResult Delete(int id)
        {
            _order.RemoveItemFromOrder(id);
            return RedirectToAction("Kurv");
        }

        public IActionResult DeleteOrder(int id)
        {
            _order.DeleteOrder(id);
            return RedirectToAction("MineOrdrer");
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            return NotFound();

            var order = _order.GetOrder(id.Value);

            return View(order);
        }

        [HttpPost]
        public IActionResult Add(ProductDetailsViewModel pdvm)
        {
            var product = _products.GetByID(pdvm.Product.Id);
            if (product is null) return NotFound();

            if (product.ProductType != ProductType.DivingSuit)
            {
                ModelState.Remove(nameof(pdvm.Gender));
            }
            if (product.ProductType is not (ProductType.BCD or ProductType.Fins or ProductType.DivingSuit))
            {
                ModelState.Remove(nameof(pdvm.Size));
            }

            pdvm.Product = product;

            var orderId = _order.GetOrCreateCurrentOrderId(_user.GetUserId(User));

            if (ModelState.IsValid)
            {
                var result = _order.AddItemToOrder(pdvm, orderId);

                if (!result.IsSuccessful)
                {
                    var key = string.IsNullOrEmpty(result.Key) ? string.Empty : result.Key;
                    ModelState.AddModelError(key, result.ErrorMessage ?? "Unknown error");
                    pdvm.Product = product;
                    // Gå til oversigten
                    return View("~/Views/Products/ProductInfo.cshtml", pdvm);
                }
            }

            return View("~/Views/Products/ProductInfo.cshtml", pdvm);
        }

        public IActionResult Kurv()
        {
            var userId = _user.GetUserId(User);

            var orderId = _order.GetOrCreateCurrentOrderId(userId);

            var currentOrder = _order.GetAllItems(orderId);

            return View(currentOrder);
        }

        [HttpPost]
        [Authorize]
        public IActionResult Oversigt(Order order)
        {
            var userId = _user.GetUserId(User);

            order.UserId = userId;

            _order.ConfirmOrder(order);
            return View();
        }

        [HttpGet]
        [Authorize]
        public IActionResult MineOrdrer()
        {
            var userId = _user.GetUserId(User);
            List<Order> orders;

            if (User.IsInRole("Admin"))
            {
                orders = _order.GetAllOrders();
            }
            else
            {
                orders = _order.GetAllOrders()
                    .Where(o => o.UserId == userId)
                    .ToList();
            }
            
            return View(orders);
        }
    }
}
