using DiamondPlaze.BusinessObject.Models;
using DiamondPlaze.Repository;

namespace DiamondPlaze.Service
{
    public class ProductTypeService : BaseService<ProductType>, IProductTypeService
    {
        public ProductTypeService(IProductTypeRepository productTypeRepository) : base(productTypeRepository)
        {
        }
    }
}