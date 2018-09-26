using System.Collections.Generic;
using System.Data.Entity;

namespace DemoDesignPatterns.Repositories
{
    public interface IBaseRepository<C, T> where T : BaseEntity where C : DbContext
    {
        T GetById(int id);
        T GetSingleBySpec(ISpecification<T> spec);
        IEnumerable<T> ListAll();
        IEnumerable<T> List(ISpecification<T> spec);
        T Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
