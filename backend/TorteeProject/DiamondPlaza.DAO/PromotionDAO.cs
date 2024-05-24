using DiamondPlaze.BusinessObject.Models;
using DiamondPlaze.DataAccess;

namespace DiamondPlaze.DataAccess
{
    public class PromotionDAO : BaseDAO<Promotion>
    {
        public PromotionDAO(DiamondPlazeDbContext context) : base(context)
        {
        }
    }
}