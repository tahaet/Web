using Microsoft.EntityFrameworkCore;
using Web.DataAccess.Configurations;
using Web.Models;

public class AppDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    public DbSet<Transaction> Transactions { get; set; }
    public DbSet<TransactionsView> TransactionsView { get; set; }

    public DbSet<Unit> Units { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

        base.OnModelCreating(modelBuilder);
    }
}
