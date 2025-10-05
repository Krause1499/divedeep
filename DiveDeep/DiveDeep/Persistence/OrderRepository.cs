using DiveDeep.Data;
using DiveDeep.Models;

namespace DiveDeep.Persistence
{
    public class OrderRepository : IOrderRepository
    {
        private readonly DiveDeepContext _context;

        public OrderRepository(DiveDeepContext context)
        {
            _context = context;
        }

        public int GetOrCreateCurrentOrderId()
        {
            var order = _context.Order
                .FirstOrDefault();

            if (order == null)
            {
                order = new Order();
                _context.Order.Add(order);
                _context.SaveChanges();
            }

            return order.OrderId;
        }

        public void AddItemToOrder(OrderItem item)
        {
            if (item == null) return;

            _context.OrderItem.Add(item);
            _context.SaveChanges();
        }

        public void RemoveItemFromOrder(OrderItem item)
        {
            throw new NotImplementedException();
        }

        public List<OrderItem> GetAllItems(int orderId)
        {
            return _context.OrderItem
                .Where(o => o.OrderId == orderId)
                .ToList();
        }
    }
}
