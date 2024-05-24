using DiamondPlaze.BusinessObject.Models;
using DiamondPlaze.DataAccess;

namespace DiamondPlaze.DataAccess
{
    public class CounterDAO : BaseDAO<Counter>
    {
        public CounterDAO(DiamondPlazeDbContext context) : base(context)
        {
        }
    }
}