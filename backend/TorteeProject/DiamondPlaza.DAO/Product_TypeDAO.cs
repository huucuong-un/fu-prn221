using DiamondPlaze.BusinessObject.Models;
using DiamondPlaze.DataAccess;

namespace DiamondPlaze.DataAccess
{
    public class ProductTypeDAO : BaseDAO<ProductType>
    {
        public ProductTypeDAO(DiamondPlazeDbContext context) : base(context)
        {
        }
    }
}