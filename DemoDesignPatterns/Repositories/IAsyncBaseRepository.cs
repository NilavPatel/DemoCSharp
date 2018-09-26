using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;

namespace DemoDesignPatterns.Repositories
{
    public interface IAsyncBaseRepository<C, T> where T : BaseEntity where C : DbContext
    {
        Task<T> GetByIdAsync(int id);
        Task<List<T>> ListAllAsync();
        Task<List<T>> ListAsync(ISpecification<T> spec);
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}
