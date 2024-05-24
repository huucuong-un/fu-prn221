using DiamondPlaze.BusinessObject.Models;
using DiamondPlaze.DataAccess;

namespace DiamondPlaze.DataAccess
{
    public class OrderDAO : BaseDAO<Order>
    {
        public OrderDAO(DiamondPlazeDbContext context) : base(context)
        {
        }
    }
}