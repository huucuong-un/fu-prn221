using DiamondPlaze.BusinessObject.Models;
using DiamondPlaze.DataAccess;

namespace DiamondPlaze.DataAccess
{
    public class TransactionDAO : BaseDAO<Transaction>
    {
        public TransactionDAO(DiamondPlazeDbContext context) : base(context)
        {
        }
    }
}