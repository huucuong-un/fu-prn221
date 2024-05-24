using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DiamondPlaze.Repository;

namespace DiamondPlaze.Service
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class
    {
        private readonly IBaseRepository<TEntity> _baseRepository;

        public BaseService(IBaseRepository<TEntity> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return _baseRepository.GetAllAsync();
        }

        public Task<TEntity> GetByIdAsync(Guid id)
        {
            return _baseRepository.GetByIdAsync(id);
        }

        public Task AddAsync(TEntity entity)
        {
            return _baseRepository.AddAsync(entity);
        }

        public Task UpdateAsync(TEntity entity)
        {
            return _baseRepository.UpdateAsync(entity);
        }

        public Task DeleteAsync(Guid id)
        {
            return _baseRepository.DeleteAsync(id);
        }
    }
}