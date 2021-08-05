using Savitar.Domain.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Savitar.Infrastructure.Repository.Shared
{
    public interface IRepository<T> where T : class, IEntity
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetAsync(int id);
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(int id);
    }
}
