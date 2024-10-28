using Web.DataAccess.Repository.IRepository;

public interface IUnitOfWork
{
    public IProductRepository Product { get; }
    public IUnitRepository Unit { get; }
    public ITransactionRepository Transaction { get; }
    public ITransactionsViewRepository TransactionsView { get; }
    Task SaveAsync();
}
