using DiveDeep.Models;
using DiveDeep.Persistence;
using DiveDeep.ViewModels;

namespace DiveDeep.Services
{
    public interface IOrderService
    {
        int GetOrCreateCurrentOrderId(string id);
        OrderResult AddItemToOrder(ProductDetailsViewModel pdvm, int orderId);
        void ConfirmOrder(Order order);
        void RemoveItemFromOrder(int id);
        Order GetAllItems(int orderId);
        List<Order> GetAllOrders();
        Order GetOrder(int orderId);
        void DeleteOrder(int orderId);
    }

    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _repo;

        public OrderService(IOrderRepository repo)
        {
            _repo = repo;
        }

        public OrderResult AddItemToOrder(ProductDetailsViewModel pdvm, int orderId)
        {
            if (pdvm == null)
                return OrderResult.Fail(string.Empty, "Intet produkt at tilføje");

            if (pdvm.StartDate >= pdvm.EndDate)
                return OrderResult.Fail(nameof(pdvm.StartDate), "Startdato må ikke være efter slutdato");

            if (pdvm.StartDate < DateOnly.FromDateTime(DateTime.UtcNow))
                return OrderResult.Fail(nameof(pdvm.StartDate), "Startdato må ikke være i fortiden");

            try
            {
                _repo.AddItemToOrder(pdvm, orderId);
                return OrderResult.Ok();
            }
            catch (InvalidOperationException ex)
            {
                return OrderResult.Fail(nameof(pdvm.StartDate), ex.Message);
            }
        }

        public void ConfirmOrder(Order order)
        {
            if (order == null)
                return;

            _repo.ConfirmOrder(order);
        }

        public void DeleteOrder(int orderId)
        {
            _repo.DeleteOrder(orderId);
        }

        public Order GetAllItems(int orderId)
        {
            var order = _repo.GetAllItems(orderId);
            return order;
        }

        public List<Order> GetAllOrders()
        {
            var orders = _repo.GetAllOrders();
            return orders;
        }

        public int GetOrCreateCurrentOrderId(string id)
        {
            var orderId = _repo.GetOrCreateCurrentOrderId(id);
            return orderId;
        }

        public Order GetOrder(int orderId)
        {
            var order = _repo.GetOrder(orderId);
            return order;
        }

        public void RemoveItemFromOrder(int id)
        {
            _repo.RemoveItemFromOrder(id);
        }
    }
}
