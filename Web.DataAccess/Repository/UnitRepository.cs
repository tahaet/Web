using Web.DataAccess.Repository.IRepository;
using Web.Models;

namespace Web.DataAccess.Repository
{
    public class UnitRepository : Repository<Unit>, IUnitRepository
    {
        private readonly AppDbContext _db;

        public UnitRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
