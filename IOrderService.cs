using Domain;

namespace Services
{
    public interface IOrderService
    {
        public List<Order> GetAllOrders();
        public Order GetOrder(int id);
        public void AddOrder(Order order);
        public void UpdateOrder(int orderId, Order order);
        public void DeleteOrder(int orderId);
        public List<Order> GetCustomerOrders(int customerId);
        public decimal GetCustomerOrdersTotal(int customerId);
        public Dictionary<int, decimal> GetAllCustomersOrdersTotal();
    }
}
