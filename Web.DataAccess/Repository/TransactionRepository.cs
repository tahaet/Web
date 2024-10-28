using Web.DataAccess.Repository.IRepository;
using Web.Models;

namespace Web.DataAccess.Repository
{
    public class TransactionRepository : Repository<Transaction>, ITransactionRepository
    {
        private readonly AppDbContext _db;

        public TransactionRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
