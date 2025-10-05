using DiveDeep.Models;

namespace DiveDeep.Persistence
{
    public interface IOrderRepository
    {
        void AddItemToOrder(OrderItem item);
        void RemoveItemFromOrder(OrderItem item);
        List<OrderItem> GetAllItems(int orderId);
        int GetOrCreateCurrentOrderId();
    }
}
