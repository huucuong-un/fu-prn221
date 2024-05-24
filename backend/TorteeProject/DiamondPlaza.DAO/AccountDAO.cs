using DiamondPlaze.BusinessObject.Models;
using DiamondPlaze.DataAccess;

namespace DiamondPlaze.DataAccess
{
    public class AccountDAO : BaseDAO<Account>
    {
        public AccountDAO(DiamondPlazeDbContext context) : base(context)
        {
        }
    }
}