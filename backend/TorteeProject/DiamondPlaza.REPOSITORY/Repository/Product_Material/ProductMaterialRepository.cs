using DiamondPlaze.BusinessObject.Models;
using DiamondPlaze.DataAccess;

namespace DiamondPlaze.Repository
{
    public class ProductMaterialRepository : BaseRepository<ProductMaterial>, IProductMaterialRepository
    {
        public ProductMaterialRepository(ProductMaterialDAO productMaterialDao) : base(productMaterialDao)
        {
        }
    }
}