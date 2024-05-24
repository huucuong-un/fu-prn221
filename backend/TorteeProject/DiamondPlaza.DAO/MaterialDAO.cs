using DiamondPlaze.BusinessObject.Models;
using DiamondPlaze.DataAccess;

namespace DiamondPlaze.DataAccess
{
    public class MaterialDAO : BaseDAO<Material>
    {
        public MaterialDAO(DiamondPlazeDbContext context) : base(context)
        {
        }
    }
}