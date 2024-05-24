using DiamondPlaze.BusinessObject.Models;
using DiamondPlaze.DataAccess;

namespace DiamondPlaze.Repository
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(ProductDAO productDao) : base(productDao)
        {
        }
    }
}