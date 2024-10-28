using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Web.Models;

namespace Web.DataAccess.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(100);
            builder.HasOne(x => x.Unit).WithMany().HasForeignKey(x => x.UnitId);
            builder.HasData(
                new Product
                {
                    Id = 1,
                    Name = "Apple",
                    UnitId = 1,
                    Price = 2.5m,
                    InitialQuantity = 100,
                }, // Unit: Kilogram
                new Product
                {
                    Id = 2,
                    Name = "Milk",
                    UnitId = 3,
                    Price = 1.2m,
                    InitialQuantity = 200,
                }, // Unit: Liter
                new Product
                {
                    Id = 3,
                    Name = "Bread",
                    UnitId = 2,
                    Price = 1.0m,
                    InitialQuantity = 150,
                }, // Unit: Piece
                new Product
                {
                    Id = 4,
                    Name = "Rice",
                    UnitId = 1,
                    Price = 0.8m,
                    InitialQuantity = 300,
                }, // Unit: Kilogram
                new Product
                {
                    Id = 5,
                    Name = "Eggs",
                    UnitId = 2,
                    Price = 0.1m,
                    InitialQuantity = 500,
                }, // Unit: Piece
                new Product
                {
                    Id = 6,
                    Name = "Orange Juice",
                    UnitId = 3,
                    Price = 2.0m,
                    InitialQuantity = 100,
                }, // Unit: Liter
                new Product
                {
                    Id = 7,
                    Name = "Cereal",
                    UnitId = 4,
                    Price = 3.5m,
                    InitialQuantity = 80,
                }, // Unit: Box
                new Product
                {
                    Id = 8,
                    Name = "Toothpaste",
                    UnitId = 5,
                    Price = 1.5m,
                    InitialQuantity = 120,
                }, // Unit: Packet
                new Product
                {
                    Id = 9,
                    Name = "Chicken Breast",
                    UnitId = 1,
                    Price = 5.0m,
                    InitialQuantity = 60,
                }, // Unit: Kilogram
                new Product
                {
                    Id = 10,
                    Name = "Soda Can",
                    UnitId = 2,
                    Price = 0.9m,
                    InitialQuantity = 400,
                } // Unit: Piece
            );
        }
    }
}
