using DiamondPlaze.BusinessObject.Models;
using DiamondPlaze.DataAccess;

namespace DiamondPlaze.DataAccess
{
    public class ProductDAO : BaseDAO<Product>
    {
        public ProductDAO(DiamondPlazeDbContext context) : base(context)
        {
        }
    }
}