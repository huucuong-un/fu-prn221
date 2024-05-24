using DiamondPlaze.BusinessObject.Models;
using DiamondPlaze.Repository;

namespace DiamondPlaze.Service
{
    public class OrderItemService : BaseService<OrderItem>, IOrderItemService
    {
        public OrderItemService(IOrderItemRepository orderItemRepository) : base(orderItemRepository)
        {
        }
    }
}