using DiamondPlaze.BusinessObject.Models;
using DiamondPlaze.DataAccess;

namespace DiamondPlaze.DataAccess
{
    public class OrderItemDAO : BaseDAO<OrderItem>
    {
        public OrderItemDAO(DiamondPlazeDbContext context) : base(context)
        {
        }
    }
}