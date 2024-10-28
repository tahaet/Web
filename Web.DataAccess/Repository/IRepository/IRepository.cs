using System.Linq.Expressions;

namespace Web.DataAccess.Repository.IRepository
{
    public interface IRepository<T>
        where T : class
    {
        Task<T> GetAsync(
            Expression<Func<T, bool>> filter,
            bool tracked = false,
            params string[]? includes
        );
        Task<IQueryable<T>> GetAllAsync(
            Expression<Func<T, bool>>? filter = null,
            bool tracked = false,
            params string[] includes
        );
        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);
    }
}
