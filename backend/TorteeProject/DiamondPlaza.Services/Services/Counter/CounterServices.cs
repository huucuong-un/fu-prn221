using DiamondPlaze.BusinessObject.Models;
using DiamondPlaze.Repository;

namespace DiamondPlaze.Service
{
    public class CounterService : BaseService<Counter>, ICounterService
    {
        public CounterService(ICounterRepository counterRepository) : base(counterRepository)
        {
        }
    }
}