using DiamondPlaze.BusinessObject.Models;
using DiamondPlaze.Repository;

namespace DiamondPlaze.Service
{
    public class RoleService : BaseService<Role>, IRoleService
    {
        public RoleService(IRoleRepository roleRepository) : base(roleRepository)
        {
        }
    }
}