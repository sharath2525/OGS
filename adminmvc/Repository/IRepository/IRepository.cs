using System.Linq.Expressions;

namespace adminmvc.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);

        void Remove(T entity);

        IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter=null, string? includeProperties = null);

        T Get(Expression<Func<T, bool>> filter, string? includeProperties = null);

        void RemoveRange(IEnumerable<T> entity);
    }
}
