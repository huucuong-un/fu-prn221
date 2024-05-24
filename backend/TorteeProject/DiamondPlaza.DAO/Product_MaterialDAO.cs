using DiamondPlaze.BusinessObject.Models;
using DiamondPlaze.DataAccess;

namespace DiamondPlaze.DataAccess
{
    public class ProductMaterialDAO : BaseDAO<ProductMaterial>
    {
        public ProductMaterialDAO(DiamondPlazeDbContext context) : base(context)
        {
        }
    }
}