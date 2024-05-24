using DiamondPlaze.BusinessObject.Models;
using DiamondPlaze.Repository;

namespace DiamondPlaze.Service
{
    public class OrderService : BaseService<Order>, IOrderService
    {
        public OrderService(IOrderRepository orderRepository) : base(orderRepository)
        {
        }
    }
}