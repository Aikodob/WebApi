using Domain;
using Data;

namespace Services
{
    public class OrderService : IOrderService
    {
        private readonly AppDbContext _dbContext;

        public OrderService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddOrder(Order order)
        {
            _dbContext.Orders.Add(order);
            _dbContext.SaveChanges();
        }

        public void DeleteOrder(int orderId)
        {
            var orderToDelete = _dbContext.Orders.FirstOrDefault(x =>  x.OrderId == orderId);
            if (orderToDelete != null)
            {
                _dbContext.Orders.Remove(orderToDelete);
            }
            _dbContext.SaveChanges();
        }

        public List<Order> GetAllOrders()
        {
            return _dbContext.Orders.ToList();
        }

        public List<Order> GetCustomerOrders(int customerId)
        {
            return _dbContext.Orders.Where(x =>  x.CustomerId == customerId).ToList();
        }

        public decimal GetCustomerOrdersTotal(int customerId)
        {
            return _dbContext.Orders.Where(x => x.CustomerId == customerId).Sum(x => x.Price);
        }

        public Dictionary<int, decimal> GetAllCustomersOrdersTotal()
        {
            return _dbContext.Orders.GroupBy(x => x.CustomerId).ToDictionary(x => x.Key, x => x.Sum(x => x.Price));
        }

        public Order GetOrder(int id)
        {
            return _dbContext.Orders.FirstOrDefault(x => x.OrderId == id);
        }

        public void UpdateOrder(int orderId, Order order)
        {
            var orderToUpdate = _dbContext.Orders.FirstOrDefault(x=> x.OrderId == orderId);
            if (orderToUpdate != null)
            {
                orderToUpdate = order;
            }
            _dbContext.SaveChanges();
        }
    }
}
