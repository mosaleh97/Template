using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.bll.Interfaces
{
    public interface IGenericService<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(object id);
        Task<T> CreateAsync(T entity);
        Task<IEnumerable<T>> CreateMultipleAsync(IEnumerable<T> entities);
        Task UpdateAsync(T entity);
        Task DeleteAsync(object id);
    }
}
