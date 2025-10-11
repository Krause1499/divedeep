using DiveDeep.Data;
using DiveDeep.Models;
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

        public void AddItemToOrder(OrderItem item)
        {
            if (item == null) return;

            _context.OrderItems.Add(item);
            _context.SaveChanges();
        }

        public void ConfirmOrder(Order order)
        {
            if (order == null) return;

            var orderToConfirm = _context.Orders.FirstOrDefault(o => o.OrderId == order.OrderId);
            orderToConfirm.IsConfirmed = true;
            orderToConfirm.UserId = order.UserId;
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
                .ToList();
        }

        public Order GetOrder(int orderId)
        {
            return _context.Orders
                .Include(o => o.Items)
                .FirstOrDefault(o => o.OrderId == orderId);
        }
    }
}
