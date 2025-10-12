using DiveDeep.Data;
using DiveDeep.Migrations;
using DiveDeep.Models;
using DiveDeep.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace DiveDeep.Persistence
{
    public class OrderRepository : IOrderRepository
    {
        private readonly DiveDeepContext _context;

        public OrderRepository(DiveDeepContext context)
        {
            _context = context;
        }

        public int GetOrCreateCurrentOrderId(string id)
        {
            var order = _context.Orders
                .Where(o => o.IsConfirmed == false)
                .FirstOrDefault(o => o.UserId == id);

            if (order == null)
            {
                order = new Order();
                order.UserId = id;
                _context.Orders.Add(order);
                _context.SaveChanges();
            }

            return order.OrderId;
        }

        public void AddItemToOrder(ProductDetailsViewModel pdvm, int orderId)
        {
            if (pdvm == null) return;

            //Find eller opret InventoryUnit
            var unit = GetInventoryUnit(pdvm);

            if (unit is null)
            {
                var size = pdvm.Size ?? Size.NA;
                var gender = pdvm.Gender ?? Gender.NA;
                unit = new InventoryUnit
                {
                    ProductId = pdvm.Product.Id,
                    Size = size,
                    Gender = gender
                };
                _context.InventoryUnits.Add(unit);
                _context.SaveChanges(); // sørger for at få unit.Id
            }

            //Tjek for overlap
            bool overlap = ExistsOverlap(unit.Id, pdvm.StartDate, pdvm.EndDate);

            if (overlap)
                throw new InvalidOperationException("Denne variant er allerede reserveret i den valgte periode.");

            //Opret OrderItem-snapshot
            var item = new OrderItem
            {
                OrderId = orderId,
                InventoryUnitId = unit.Id,
                FilePath = pdvm.Product.FilePath,
                Brand = pdvm.Product.Brand,
                Price = pdvm.Product.DailyPrice,
                ProductType = pdvm.Product.ProductType,
                StartDate = pdvm.StartDate,
                EndDate = pdvm.EndDate,
                Size = pdvm.Size,
                Gender = pdvm.Gender
            };

            _context.OrderItems.Add(item);
            _context.SaveChanges();
        }


        public void ConfirmOrder(Order order)
        {
            if (order == null) return;

            var orderToConfirm = _context.Orders.FirstOrDefault(o => o.OrderId == order.OrderId);
            orderToConfirm.IsConfirmed = true;
            orderToConfirm.UserId = order.UserId;
            orderToConfirm.TotalPrice = order.TotalPrice;
            _context.SaveChanges();
        }

        public void RemoveItemFromOrder(int id)
        {
            var entityToDelete = _context.OrderItems.Find(id);
            if (entityToDelete == null) return;

            _context.Remove(entityToDelete);
            _context.SaveChanges();
        }

        public Order GetAllItems(int orderId)
        {
            return _context.Orders
                .Include(o => o.Items)
                .FirstOrDefault(o => o.OrderId == orderId);
        }

        public List<Order> GetAllOrders()
        {
            return _context.Orders
                .Include(o => o.User)
                .Where(o => o.IsConfirmed == true)
                .ToList();
        }

        public Order GetOrder(int orderId)
        {
            return _context.Orders
                .Include(o => o.Items)
                .FirstOrDefault(o => o.OrderId == orderId);
        }

        public bool ExistsOverlap(int inventoryUnitId, DateOnly? startDate, DateOnly? endDate)
        {
            return _context.OrderItems
                .Where(oi => oi.InventoryUnitId == inventoryUnitId)
                .Where(oi => oi.Order.IsConfirmed == true)
                .Any(oi => oi.StartDate < endDate &&
                    startDate < oi.EndDate);
        }

        public InventoryUnit GetInventoryUnit(ProductDetailsViewModel pdvm)
        {
            var size = pdvm.Size ?? Size.NA;
            var gender = pdvm.Gender ?? Gender.NA;

            return _context.InventoryUnits.SingleOrDefault(io =>
            io.ProductId == pdvm.Product.Id &&
            io.Size == size &&
            io.Gender == gender);
        }

        public void DeleteOrder(int orderId)
        {
            _context.Orders
                .Remove(GetOrder(orderId));
            _context.SaveChanges();
        }
    }
}
