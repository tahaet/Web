using Web.DataAccess.Repository;

public class TransactionsViewRepository : Repository<TransactionsView>, ITransactionsViewRepository
{
    private readonly AppDbContext _db;

    public TransactionsViewRepository(AppDbContext db)
        : base(db)
    {
        _db = db;
    }
}
