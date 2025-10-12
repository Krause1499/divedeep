using DiveDeep.Models;
using DiveDeep.ViewModels;

namespace DiveDeep.Persistence
{
    public interface IOrderRepository
    {
        void AddItemToOrder(ProductDetailsViewModel pdvm, int orderId);
        void RemoveItemFromOrder(int id);
        Order GetAllItems(int orderId);
        int GetOrCreateCurrentOrderId(string id);
        void ConfirmOrder(Order order);
        List<Order> GetAllOrders();
        Order GetOrder(int orderId);
        InventoryUnit GetInventoryUnit(ProductDetailsViewModel pdvm);
        void DeleteOrder(int orderId);
    }
}
