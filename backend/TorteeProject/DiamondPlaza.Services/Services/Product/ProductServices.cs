using DiamondPlaze.BusinessObject.Models;
using DiamondPlaze.Repository;

namespace DiamondPlaze.Service
{
    public class ProductService : BaseService<Product>, IProductService
    {
        public ProductService(IProductRepository productRepository) : base(productRepository)
        {
        }
    }
}