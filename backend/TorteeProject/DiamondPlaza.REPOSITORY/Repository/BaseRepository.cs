using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DiamondPlaze.DataAccess;

namespace DiamondPlaze.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly BaseDAO<TEntity> _baseDao;

        public BaseRepository(BaseDAO<TEntity> baseDao)
        {
            _baseDao = baseDao;
        }

        public Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return _baseDao.GetAllAsync();
        }

        public Task<TEntity> GetByIdAsync(Guid id)
        {
            return _baseDao.GetByIdAsync(id);
        }

        public Task AddAsync(TEntity entity)
        {
            return _baseDao.AddAsync(entity);
        }

        public Task UpdateAsync(TEntity entity)
        {
            return _baseDao.UpdateAsync(entity);
        }

        public Task DeleteAsync(Guid id)
        {
            return _baseDao.DeleteAsync(id);
        }
    }
}