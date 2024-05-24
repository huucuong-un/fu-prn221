using DiamondPlaze.BusinessObject.Models;
using DiamondPlaze.Repository;

namespace DiamondPlaze.Service
{
    public class ProductMaterialService : BaseService<ProductMaterial>, IProductMaterialService
    {
        public ProductMaterialService(IProductMaterialRepository productMaterialRepository) : base(productMaterialRepository)
        {
        }
    }
}