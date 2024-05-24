using DiamondPlaze.BusinessObject.Models;
using DiamondPlaze.DataAccess;

namespace DiamondPlaze.DataAccess
{
    public class CustomerDAO : BaseDAO<Customer>
    {
        public CustomerDAO(DiamondPlazeDbContext context) : base(context)
        {
        }
    }
}