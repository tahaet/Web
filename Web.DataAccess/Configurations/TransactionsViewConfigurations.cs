using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class TransactionsViewConfigurations : IEntityTypeConfiguration<TransactionsView>
{
    public void Configure(EntityTypeBuilder<TransactionsView> builder)
    {
        builder.ToView("TransactionsView").HasNoKey();
    }
}
