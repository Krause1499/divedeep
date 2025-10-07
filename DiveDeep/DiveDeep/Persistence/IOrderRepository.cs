using DiveDeep.Models;

namespace DiveDeep.Persistence
{
    public interface IOrderRepository
    {
        void AddItemToOrder(OrderItem item);
        void RemoveItemFromOrder(OrderItem item);
        Order GetAllItems(int orderId);
        int GetOrCreateCurrentOrderId();
        void ConfirmOrder(Order order);
    }
}
