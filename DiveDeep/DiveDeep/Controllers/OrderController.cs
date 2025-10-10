using DiveDeep.Models;
using DiveDeep.Persistence;
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
        private readonly IOrderRepository _order;
        private readonly UserManager<ApplicationUser> _user;

        public OrderController(IProductRepository products, IOrderRepository order, UserManager<ApplicationUser> user)
        {
            _products = products;
            _order = order;
            _user = user;
        }

        [HttpPost]
        public IActionResult Add(ProductDetailsViewModel pdvm)
        {
            var product = _products.GetByID(pdvm.Product.Id);
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

            var userId = _user.GetUserId(User);

            var orderId = _order.GetOrCreateCurrentOrderId(userId);

                if (ModelState.IsValid)
                {
                    // Lav et snapshot (OrderItem) ud fra produktet
                    var item = new OrderItem
                    {
                        OrderId = orderId,
                        FilePath = product.FilePath,
                        Brand = product.Brand,
                        Price = product.DailyPrice,
                        ProductType = product.ProductType,
                        StartDate = pdvm.StartDate,
                        EndDate = pdvm.EndDate
                    };

                if (product.ProductType is ProductType.BCD)
                {
                    item.Size = pdvm.Size;
                }

                if (product.ProductType is ProductType.DivingSuit)
                {
                    item.Size = pdvm.Size;
                    item.Gender = pdvm.Gender;
                }

                if (product.ProductType is ProductType.Fins)
                {
                    item.Size = pdvm.Size;
                }

                _order.AddItemToOrder(item);
                pdvm.Product = product;
                return View("~/Views/Products/ProductInfo.cshtml", pdvm);
                }

            pdvm.Product = product;
            // Gå til oversigten
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
