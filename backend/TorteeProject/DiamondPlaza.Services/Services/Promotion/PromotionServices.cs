using DiamondPlaze.BusinessObject.Models;
using DiamondPlaze.Repository;

namespace DiamondPlaze.Service
{
    public class PromotionService : BaseService<Promotion>, IPromotionService
    {
        public PromotionService(IPromotionRepository promotionRepository) : base(promotionRepository)
        {
        }
    }
}