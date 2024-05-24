using DiamondPlaze.BusinessObject.Models;
using DiamondPlaze.Repository;

namespace DiamondPlaze.Service
{
    public class CustomerService : BaseService<Customer>, ICustomerService
    {
        public CustomerService(ICustomerRepository customerRepository) : base(customerRepository)
        {
        }
    }
}