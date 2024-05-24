using DiamondPlaze.BusinessObject.Models;
using DiamondPlaze.Repository;

namespace DiamondPlaze.Service
{
    public class MaterialService : BaseService<Material>, IMaterialService
    {
        public MaterialService(IMaterialRepository materialRepository) : base(materialRepository)
        {
        }
    }
}