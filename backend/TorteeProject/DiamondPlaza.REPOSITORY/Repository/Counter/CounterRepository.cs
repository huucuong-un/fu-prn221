using DiamondPlaze.BusinessObject.Models;
using DiamondPlaze.DataAccess;

namespace DiamondPlaze.Repository
{
    public class CounterRepository : BaseRepository<Counter>, ICounterRepository
    {
        public CounterRepository(CounterDAO counterDao) : base(counterDao)
        {
        }
    }
}