using DiamondPlaze.BusinessObject.Models;
using DiamondPlaze.DataAccess;

namespace DiamondPlaze.DataAccess
{
    public class RoleDAO : BaseDAO<Role>
    {
        public RoleDAO(DiamondPlazeDbContext context) : base(context)
        {
        }
    }
}