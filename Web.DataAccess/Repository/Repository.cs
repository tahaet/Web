using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Web.DataAccess.Repository.IRepository;

namespace Web.DataAccess.Repository
{
    public class Repository<T> : IRepository<T>
        where T : class
    {
        private readonly AppDbContext _db;

        public Repository(AppDbContext db)
        {
            _db = db;
        }

        public void Add(T entity)
        {
            _db.Set<T>().Add(entity);
        }

        public async Task<IQueryable<T>> GetAllAsync(
            Expression<Func<T, bool>>? filter = null,
            bool tracked = false,
            params string[]? includes
        )
        {
            IQueryable<T> query = null;
            if (tracked)
            {
                query = _db.Set<T>();
            }
            else
            {
                query = _db.Set<T>().AsNoTracking();
            }

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (includes is not null)
            {
                foreach (var include in includes)
                {
                    query.Include(include);
                }
            }
            return query.AsQueryable();
        }

        public async Task<T> GetAsync(
            Expression<Func<T, bool>> filter,
            bool tracked = false,
            params string[]? includes
        )
        {
            IQueryable<T> query = null;
            if (tracked)
            {
                query = _db.Set<T>();
            }
            else
            {
                query = _db.Set<T>().AsNoTracking();
            }

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (includes is not null)
            {
                foreach (var include in includes)
                {
                    query.Include(include);
                }
            }
            return await query.FirstOrDefaultAsync();
        }

        public void Remove(T entity)
        {
            _db.Set<T>().Remove(entity);
        }

        public void Update(T entity)
        {
            _db.Update(entity);
        }
    }
}
