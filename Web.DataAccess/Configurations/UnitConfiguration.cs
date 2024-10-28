using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Web.Models;

namespace Web.DataAccess.Configurations
{
    public class UnitConfiguration : IEntityTypeConfiguration<Unit>
    {
        public void Configure(EntityTypeBuilder<Unit> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(100);
            builder.HasData(new Unit { Id = 1, Name = "Kilogram" },
                            new Unit { Id = 2, Name = "Piece" },
                            new Unit { Id = 3, Name = "Liter" },
                            new Unit { Id = 4, Name = "Box" },
                            new Unit { Id = 5, Name = "Packet" });
        }
    }
}
