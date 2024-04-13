using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.bll.Interfaces;
using Template.dal.Interfaces;

namespace Template.bll.Implementations
{
    public class GenericService<T> : IGenericService<T> where T : class
    {
        private readonly IGenericRepository<T> _repository;

        public GenericService(IGenericRepository<T> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<T> GetByIdAsync(object id)
        {
            return await _repository.GetAsync(id);
        }

        public async Task<T> CreateAsync(T entity)
        {
            return await _repository.AddAsync(entity);
        }

        public async Task UpdateAsync(T entity)
        {
            await _repository.UpdateAsync(entity);
        }

        public async Task DeleteAsync(object id)
        {
            await _repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<T>> CreateMultipleAsync(IEnumerable<T> entities)
        {
            return await _repository.AddRangeAsync(entities);
        }
    }
}
