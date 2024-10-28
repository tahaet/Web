using Web.DataAccess.Repository;
using Web.DataAccess.Repository.IRepository;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _db;

    public IUnitRepository Unit { get; private set; }
    public IProductRepository Product { get; private set; }
    public ITransactionRepository Transaction { get; private set; }
    public ITransactionsViewRepository TransactionsView { get; private set; }

    public UnitOfWork(AppDbContext db)
    {
        _db = db;
        Unit = new UnitRepository(_db);
        Product = new ProductRepository(_db);
        Transaction = new TransactionRepository(_db);
        TransactionsView = new TransactionsViewRepository(_db);
    }

    public async Task SaveAsync()
    {
        await _db.SaveChangesAsync();
    }
}
