using Domain;
using Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet("GetAllOrders")]
        public List<Order> GetAllOrders()
        {
            return _orderService.GetAllOrders();
        }
        [HttpGet("GetOrder")]
        public Order GetOrder(int id)
        {
            return _orderService.GetOrder(id);
        }

        [HttpPost("AddOrder")]
        public void AddOrder(Order order)
        {
            _orderService.AddOrder(order);
        }

        [HttpPut("UpdateOrder")]
        public void UpdateOrder(int orderId, Order order)
        {
            _orderService.UpdateOrder(orderId, order);
        }

        [HttpDelete("DeleteOrder")]
        public void DeleteOrder(int orderId)
        {
            _orderService.DeleteOrder(orderId);
        }

        [HttpGet("GetCustomerOrders")]
        public List<Order> GetCustomerOrders(int customerId)
        {
            return _orderService.GetCustomerOrders(customerId);
        }

        [HttpGet("GetCustomerOrdersTotal")]
        public decimal GetCustomerOrdersTotal(int customerId)
        {
            return _orderService.GetCustomerOrdersTotal(customerId);
        }

        [HttpGet("GetAllCustomersOrdersTotal")]
        public Dictionary<int, decimal> GetAllCustomersOrdersTotal()
        {
            return _orderService.GetAllCustomersOrdersTotal();
        }
    }
}
