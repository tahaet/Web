using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Web.Models;

namespace Web.DataAccess.Configurations
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.HasIndex(x => x.Date);
            builder.HasOne(x => x.Product).WithMany().HasForeignKey(x => x.ProductId);
            builder.HasData(
                new Transaction
                {
                    Id = 1,
                    ProductId = 7,
                    Quantity = 82,
                    Date = new DateTime(2024, 6, 28),
                    TotalPrice = 287.0m,
                },
                new Transaction
                {
                    Id = 2,
                    ProductId = 5,
                    Quantity = 9,
                    Date = new DateTime(2024, 9, 10),
                    TotalPrice = 0.9m,
                },
                new Transaction
                {
                    Id = 3,
                    ProductId = 5,
                    Quantity = 85,
                    Date = new DateTime(2024, 9, 7),
                    TotalPrice = 8.5m,
                },
                new Transaction
                {
                    Id = 4,
                    ProductId = 1,
                    Quantity = 34,
                    Date = new DateTime(2023, 12, 13),
                    TotalPrice = 85.0m,
                },
                new Transaction
                {
                    Id = 5,
                    ProductId = 1,
                    Quantity = 91,
                    Date = new DateTime(2024, 8, 1),
                    TotalPrice = 227.5m,
                },
                new Transaction
                {
                    Id = 6,
                    ProductId = 6,
                    Quantity = 48,
                    Date = new DateTime(2024, 6, 9),
                    TotalPrice = 96.0m,
                },
                new Transaction
                {
                    Id = 7,
                    ProductId = 9,
                    Quantity = 58,
                    Date = new DateTime(2024, 1, 4),
                    TotalPrice = 290.0m,
                },
                new Transaction
                {
                    Id = 8,
                    ProductId = 8,
                    Quantity = 69,
                    Date = new DateTime(2024, 7, 12),
                    TotalPrice = 103.5m,
                },
                new Transaction
                {
                    Id = 9,
                    ProductId = 10,
                    Quantity = 88,
                    Date = new DateTime(2024, 8, 20),
                    TotalPrice = 79.2m,
                },
                new Transaction
                {
                    Id = 10,
                    ProductId = 8,
                    Quantity = 67,
                    Date = new DateTime(2024, 10, 23),
                    TotalPrice = 100.5m,
                },
                new Transaction
                {
                    Id = 11,
                    ProductId = 2,
                    Quantity = 78,
                    Date = new DateTime(2024, 2, 2),
                    TotalPrice = 93.6m,
                },
                new Transaction
                {
                    Id = 12,
                    ProductId = 9,
                    Quantity = 33,
                    Date = new DateTime(2024, 4, 12),
                    TotalPrice = 165.0m,
                },
                new Transaction
                {
                    Id = 13,
                    ProductId = 8,
                    Quantity = 63,
                    Date = new DateTime(2024, 8, 27),
                    TotalPrice = 94.5m,
                },
                new Transaction
                {
                    Id = 14,
                    ProductId = 7,
                    Quantity = 1,
                    Date = new DateTime(2024, 9, 4),
                    TotalPrice = 3.5m,
                },
                new Transaction
                {
                    Id = 15,
                    ProductId = 10,
                    Quantity = 27,
                    Date = new DateTime(2023, 12, 13),
                    TotalPrice = 24.3m,
                },
                new Transaction
                {
                    Id = 16,
                    ProductId = 9,
                    Quantity = 68,
                    Date = new DateTime(2023, 11, 12),
                    TotalPrice = 340.0m,
                },
                new Transaction
                {
                    Id = 17,
                    ProductId = 1,
                    Quantity = 29,
                    Date = new DateTime(2023, 11, 8),
                    TotalPrice = 72.5m,
                },
                new Transaction
                {
                    Id = 18,
                    ProductId = 5,
                    Quantity = 33,
                    Date = new DateTime(2024, 8, 12),
                    TotalPrice = 3.3m,
                },
                new Transaction
                {
                    Id = 19,
                    ProductId = 10,
                    Quantity = 89,
                    Date = new DateTime(2024, 9, 8),
                    TotalPrice = 80.1m,
                },
                new Transaction
                {
                    Id = 20,
                    ProductId = 1,
                    Quantity = 45,
                    Date = new DateTime(2024, 8, 10),
                    TotalPrice = 112.5m,
                },
                new Transaction
                {
                    Id = 21,
                    ProductId = 10,
                    Quantity = 76,
                    Date = new DateTime(2024, 8, 22),
                    TotalPrice = 68.4m,
                },
                new Transaction
                {
                    Id = 22,
                    ProductId = 2,
                    Quantity = 83,
                    Date = new DateTime(2024, 4, 3),
                    TotalPrice = 99.6m,
                },
                new Transaction
                {
                    Id = 23,
                    ProductId = 2,
                    Quantity = 15,
                    Date = new DateTime(2024, 3, 31),
                    TotalPrice = 18.0m,
                },
                new Transaction
                {
                    Id = 24,
                    ProductId = 7,
                    Quantity = 81,
                    Date = new DateTime(2023, 12, 22),
                    TotalPrice = 283.5m,
                },
                new Transaction
                {
                    Id = 25,
                    ProductId = 3,
                    Quantity = 21,
                    Date = new DateTime(2024, 4, 3),
                    TotalPrice = 21.0m,
                },
                new Transaction
                {
                    Id = 26,
                    ProductId = 7,
                    Quantity = 81,
                    Date = new DateTime(2024, 5, 29),
                    TotalPrice = 283.5m,
                },
                new Transaction
                {
                    Id = 27,
                    ProductId = 5,
                    Quantity = 9,
                    Date = new DateTime(2024, 8, 16),
                    TotalPrice = 0.9m,
                },
                new Transaction
                {
                    Id = 28,
                    ProductId = 3,
                    Quantity = 69,
                    Date = new DateTime(2024, 6, 11),
                    TotalPrice = 69.0m,
                },
                new Transaction
                {
                    Id = 29,
                    ProductId = 1,
                    Quantity = 74,
                    Date = new DateTime(2024, 5, 19),
                    TotalPrice = 185.0m,
                },
                new Transaction
                {
                    Id = 30,
                    ProductId = 6,
                    Quantity = 95,
                    Date = new DateTime(2024, 5, 21),
                    TotalPrice = 190.0m,
                },
                new Transaction
                {
                    Id = 31,
                    ProductId = 5,
                    Quantity = 70,
                    Date = new DateTime(2024, 8, 23),
                    TotalPrice = 7.0m,
                },
                new Transaction
                {
                    Id = 32,
                    ProductId = 10,
                    Quantity = 71,
                    Date = new DateTime(2024, 7, 29),
                    TotalPrice = 63.9m,
                },
                new Transaction
                {
                    Id = 33,
                    ProductId = 10,
                    Quantity = 85,
                    Date = new DateTime(2024, 5, 18),
                    TotalPrice = 76.5m,
                },
                new Transaction
                {
                    Id = 34,
                    ProductId = 4,
                    Quantity = 74,
                    Date = new DateTime(2024, 4, 19),
                    TotalPrice = 59.2m,
                },
                new Transaction
                {
                    Id = 35,
                    ProductId = 4,
                    Quantity = 35,
                    Date = new DateTime(2024, 5, 4),
                    TotalPrice = 28.0m,
                },
                new Transaction
                {
                    Id = 36,
                    ProductId = 2,
                    Quantity = 25,
                    Date = new DateTime(2024, 9, 12),
                    TotalPrice = 30.0m,
                },
                new Transaction
                {
                    Id = 37,
                    ProductId = 7,
                    Quantity = 29,
                    Date = new DateTime(2024, 9, 26),
                    TotalPrice = 101.5m,
                },
                new Transaction
                {
                    Id = 38,
                    ProductId = 8,
                    Quantity = 62,
                    Date = new DateTime(2024, 6, 20),
                    TotalPrice = 93.0m,
                },
                new Transaction
                {
                    Id = 39,
                    ProductId = 1,
                    Quantity = 72,
                    Date = new DateTime(2024, 10, 1),
                    TotalPrice = 180.0m,
                },
                new Transaction
                {
                    Id = 40,
                    ProductId = 9,
                    Quantity = 9,
                    Date = new DateTime(2024, 9, 25),
                    TotalPrice = 45.0m,
                },
                new Transaction
                {
                    Id = 41,
                    ProductId = 2,
                    Quantity = 62,
                    Date = new DateTime(2024, 8, 15),
                    TotalPrice = 74.4m,
                },
                new Transaction
                {
                    Id = 42,
                    ProductId = 2,
                    Quantity = 29,
                    Date = new DateTime(2024, 9, 19),
                    TotalPrice = 34.8m,
                },
                new Transaction
                {
                    Id = 43,
                    ProductId = 7,
                    Quantity = 27,
                    Date = new DateTime(2024, 4, 29),
                    TotalPrice = 94.5m,
                },
                new Transaction
                {
                    Id = 44,
                    ProductId = 4,
                    Quantity = 71,
                    Date = new DateTime(2023, 11, 14),
                    TotalPrice = 56.8m,
                },
                new Transaction
                {
                    Id = 45,
                    ProductId = 10,
                    Quantity = 12,
                    Date = new DateTime(2024, 6, 23),
                    TotalPrice = 10.8m,
                },
                new Transaction
                {
                    Id = 46,
                    ProductId = 7,
                    Quantity = 85,
                    Date = new DateTime(2024, 6, 26),
                    TotalPrice = 297.5m,
                },
                new Transaction
                {
                    Id = 47,
                    ProductId = 9,
                    Quantity = 92,
                    Date = new DateTime(2024, 5, 3),
                    TotalPrice = 460.0m,
                },
                new Transaction
                {
                    Id = 48,
                    ProductId = 4,
                    Quantity = 89,
                    Date = new DateTime(2024, 2, 28),
                    TotalPrice = 71.2m,
                },
                new Transaction
                {
                    Id = 49,
                    ProductId = 4,
                    Quantity = 70,
                    Date = new DateTime(2024, 9, 29),
                    TotalPrice = 56.0m,
                },
                new Transaction
                {
                    Id = 50,
                    ProductId = 9,
                    Quantity = 94,
                    Date = new DateTime(2023, 10, 31),
                    TotalPrice = 470.0m,
                },
                new Transaction
                {
                    Id = 51,
                    ProductId = 2,
                    Quantity = 17,
                    Date = new DateTime(2024, 1, 22),
                    TotalPrice = 20.4m,
                },
                new Transaction
                {
                    Id = 52,
                    ProductId = 4,
                    Quantity = 19,
                    Date = new DateTime(2024, 9, 12),
                    TotalPrice = 15.2m,
                },
                new Transaction
                {
                    Id = 53,
                    ProductId = 4,
                    Quantity = 25,
                    Date = new DateTime(2024, 10, 6),
                    TotalPrice = 20.0m,
                },
                new Transaction
                {
                    Id = 54,
                    ProductId = 4,
                    Quantity = 46,
                    Date = new DateTime(2023, 11, 2),
                    TotalPrice = 36.8m,
                },
                new Transaction
                {
                    Id = 55,
                    ProductId = 7,
                    Quantity = 32,
                    Date = new DateTime(2024, 3, 30),
                    TotalPrice = 112.0m,
                },
                new Transaction
                {
                    Id = 56,
                    ProductId = 2,
                    Quantity = 75,
                    Date = new DateTime(2024, 4, 25),
                    TotalPrice = 90.0m,
                },
                new Transaction
                {
                    Id = 57,
                    ProductId = 1,
                    Quantity = 35,
                    Date = new DateTime(2023, 12, 15),
                    TotalPrice = 87.5m,
                },
                new Transaction
                {
                    Id = 58,
                    ProductId = 8,
                    Quantity = 91,
                    Date = new DateTime(2024, 8, 29),
                    TotalPrice = 136.5m,
                },
                new Transaction
                {
                    Id = 59,
                    ProductId = 7,
                    Quantity = 81,
                    Date = new DateTime(2024, 2, 3),
                    TotalPrice = 283.5m,
                },
                new Transaction
                {
                    Id = 60,
                    ProductId = 6,
                    Quantity = 79,
                    Date = new DateTime(2024, 3, 23),
                    TotalPrice = 158.0m,
                },
                new Transaction
                {
                    Id = 61,
                    ProductId = 1,
                    Quantity = 85,
                    Date = new DateTime(2024, 7, 2),
                    TotalPrice = 212.5m,
                },
                new Transaction
                {
                    Id = 62,
                    ProductId = 6,
                    Quantity = 15,
                    Date = new DateTime(2024, 4, 13),
                    TotalPrice = 30.0m,
                },
                new Transaction
                {
                    Id = 63,
                    ProductId = 2,
                    Quantity = 62,
                    Date = new DateTime(2023, 11, 23),
                    TotalPrice = 74.4m,
                },
                new Transaction
                {
                    Id = 64,
                    ProductId = 3,
                    Quantity = 36,
                    Date = new DateTime(2024, 3, 22),
                    TotalPrice = 36.0m,
                },
                new Transaction
                {
                    Id = 65,
                    ProductId = 3,
                    Quantity = 52,
                    Date = new DateTime(2024, 5, 9),
                    TotalPrice = 52.0m,
                },
                new Transaction
                {
                    Id = 66,
                    ProductId = 5,
                    Quantity = 69,
                    Date = new DateTime(2024, 4, 4),
                    TotalPrice = 6.9m,
                },
                new Transaction
                {
                    Id = 67,
                    ProductId = 1,
                    Quantity = 22,
                    Date = new DateTime(2023, 11, 19),
                    TotalPrice = 55.0m,
                },
                new Transaction
                {
                    Id = 68,
                    ProductId = 6,
                    Quantity = 82,
                    Date = new DateTime(2024, 3, 24),
                    TotalPrice = 164.0m,
                },
                new Transaction
                {
                    Id = 69,
                    ProductId = 2,
                    Quantity = 44,
                    Date = new DateTime(2024, 7, 26),
                    TotalPrice = 52.8m,
                },
                new Transaction
                {
                    Id = 70,
                    ProductId = 7,
                    Quantity = 76,
                    Date = new DateTime(2024, 6, 14),
                    TotalPrice = 266.0m,
                },
                new Transaction
                {
                    Id = 71,
                    ProductId = 4,
                    Quantity = 79,
                    Date = new DateTime(2024, 5, 15),
                    TotalPrice = 63.2m,
                },
                new Transaction
                {
                    Id = 72,
                    ProductId = 5,
                    Quantity = 36,
                    Date = new DateTime(2024, 3, 21),
                    TotalPrice = 3.6m,
                },
                new Transaction
                {
                    Id = 73,
                    ProductId = 7,
                    Quantity = 13,
                    Date = new DateTime(2024, 8, 26),
                    TotalPrice = 45.5m,
                },
                new Transaction
                {
                    Id = 74,
                    ProductId = 1,
                    Quantity = 95,
                    Date = new DateTime(2024, 9, 9),
                    TotalPrice = 237.5m,
                },
                new Transaction
                {
                    Id = 75,
                    ProductId = 6,
                    Quantity = 79,
                    Date = new DateTime(2023, 11, 1),
                    TotalPrice = 158.0m,
                },
                new Transaction
                {
                    Id = 76,
                    ProductId = 3,
                    Quantity = 46,
                    Date = new DateTime(2024, 6, 8),
                    TotalPrice = 46.0m,
                },
                new Transaction
                {
                    Id = 77,
                    ProductId = 7,
                    Quantity = 11,
                    Date = new DateTime(2024, 9, 13),
                    TotalPrice = 38.5m,
                },
                new Transaction
                {
                    Id = 78,
                    ProductId = 2,
                    Quantity = 45,
                    Date = new DateTime(2024, 4, 2),
                    TotalPrice = 54.0m,
                },
                new Transaction
                {
                    Id = 79,
                    ProductId = 7,
                    Quantity = 46,
                    Date = new DateTime(2024, 10, 16),
                    TotalPrice = 161.0m,
                },
                new Transaction
                {
                    Id = 80,
                    ProductId = 8,
                    Quantity = 38,
                    Date = new DateTime(2024, 2, 12),
                    TotalPrice = 57.0m,
                },
                new Transaction
                {
                    Id = 81,
                    ProductId = 3,
                    Quantity = 59,
                    Date = new DateTime(2023, 12, 17),
                    TotalPrice = 59.0m,
                },
                new Transaction
                {
                    Id = 82,
                    ProductId = 6,
                    Quantity = 84,
                    Date = new DateTime(2024, 4, 5),
                    TotalPrice = 168.0m,
                },
                new Transaction
                {
                    Id = 83,
                    ProductId = 2,
                    Quantity = 82,
                    Date = new DateTime(2024, 8, 28),
                    TotalPrice = 98.4m,
                },
                new Transaction
                {
                    Id = 84,
                    ProductId = 9,
                    Quantity = 84,
                    Date = new DateTime(2024, 4, 6),
                    TotalPrice = 420.0m,
                },
                new Transaction
                {
                    Id = 85,
                    ProductId = 4,
                    Quantity = 5,
                    Date = new DateTime(2024, 7, 20),
                    TotalPrice = 4.0m,
                },
                new Transaction
                {
                    Id = 86,
                    ProductId = 9,
                    Quantity = 100,
                    Date = new DateTime(2024, 10, 16),
                    TotalPrice = 500.0m,
                },
                new Transaction
                {
                    Id = 87,
                    ProductId = 7,
                    Quantity = 86,
                    Date = new DateTime(2023, 11, 3),
                    TotalPrice = 301.0m,
                },
                new Transaction
                {
                    Id = 88,
                    ProductId = 9,
                    Quantity = 91,
                    Date = new DateTime(2024, 3, 6),
                    TotalPrice = 455.0m,
                },
                new Transaction
                {
                    Id = 89,
                    ProductId = 3,
                    Quantity = 23,
                    Date = new DateTime(2024, 6, 26),
                    TotalPrice = 23.0m,
                },
                new Transaction
                {
                    Id = 90,
                    ProductId = 9,
                    Quantity = 81,
                    Date = new DateTime(2023, 12, 6),
                    TotalPrice = 405.0m,
                },
                new Transaction
                {
                    Id = 91,
                    ProductId = 6,
                    Quantity = 94,
                    Date = new DateTime(2024, 1, 28),
                    TotalPrice = 188.0m,
                },
                new Transaction
                {
                    Id = 92,
                    ProductId = 5,
                    Quantity = 76,
                    Date = new DateTime(2024, 6, 19),
                    TotalPrice = 7.6m,
                },
                new Transaction
                {
                    Id = 93,
                    ProductId = 3,
                    Quantity = 3,
                    Date = new DateTime(2023, 11, 15),
                    TotalPrice = 3.0m,
                },
                new Transaction
                {
                    Id = 94,
                    ProductId = 5,
                    Quantity = 13,
                    Date = new DateTime(2024, 3, 10),
                    TotalPrice = 1.3m,
                },
                new Transaction
                {
                    Id = 95,
                    ProductId = 3,
                    Quantity = 83,
                    Date = new DateTime(2024, 7, 19),
                    TotalPrice = 83.0m,
                },
                new Transaction
                {
                    Id = 96,
                    ProductId = 6,
                    Quantity = 78,
                    Date = new DateTime(2024, 6, 3),
                    TotalPrice = 156.0m,
                },
                new Transaction
                {
                    Id = 97,
                    ProductId = 3,
                    Quantity = 85,
                    Date = new DateTime(2024, 5, 10),
                    TotalPrice = 85.0m,
                },
                new Transaction
                {
                    Id = 98,
                    ProductId = 10,
                    Quantity = 12,
                    Date = new DateTime(2024, 4, 19),
                    TotalPrice = 10.8m,
                },
                new Transaction
                {
                    Id = 99,
                    ProductId = 8,
                    Quantity = 42,
                    Date = new DateTime(2024, 2, 22),
                    TotalPrice = 63.0m,
                },
                new Transaction
                {
                    Id = 100,
                    ProductId = 3,
                    Quantity = 31,
                    Date = new DateTime(2024, 3, 19),
                    TotalPrice = 31.0m,
                },
                new Transaction
                {
                    Id = 101,
                    ProductId = 3,
                    Quantity = 27,
                    Date = new DateTime(2024, 10, 23),
                    TotalPrice = 27.0m,
                },
                new Transaction
                {
                    Id = 102,
                    ProductId = 3,
                    Quantity = 30,
                    Date = new DateTime(2023, 12, 7),
                    TotalPrice = 30.0m,
                },
                new Transaction
                {
                    Id = 103,
                    ProductId = 9,
                    Quantity = 94,
                    Date = new DateTime(2024, 7, 13),
                    TotalPrice = 470.0m,
                },
                new Transaction
                {
                    Id = 104,
                    ProductId = 10,
                    Quantity = 55,
                    Date = new DateTime(2023, 11, 9),
                    TotalPrice = 49.5m,
                },
                new Transaction
                {
                    Id = 105,
                    ProductId = 1,
                    Quantity = 18,
                    Date = new DateTime(2024, 2, 5),
                    TotalPrice = 45.0m,
                },
                new Transaction
                {
                    Id = 106,
                    ProductId = 4,
                    Quantity = 65,
                    Date = new DateTime(2024, 9, 29),
                    TotalPrice = 52.0m,
                },
                new Transaction
                {
                    Id = 107,
                    ProductId = 4,
                    Quantity = 69,
                    Date = new DateTime(2024, 5, 17),
                    TotalPrice = 55.2m,
                },
                new Transaction
                {
                    Id = 108,
                    ProductId = 10,
                    Quantity = 59,
                    Date = new DateTime(2023, 11, 12),
                    TotalPrice = 53.1m,
                },
                new Transaction
                {
                    Id = 109,
                    ProductId = 5,
                    Quantity = 58,
                    Date = new DateTime(2024, 1, 2),
                    TotalPrice = 5.8m,
                },
                new Transaction
                {
                    Id = 110,
                    ProductId = 3,
                    Quantity = 74,
                    Date = new DateTime(2024, 6, 25),
                    TotalPrice = 74.0m,
                },
                new Transaction
                {
                    Id = 111,
                    ProductId = 7,
                    Quantity = 5,
                    Date = new DateTime(2024, 2, 11),
                    TotalPrice = 17.5m,
                },
                new Transaction
                {
                    Id = 112,
                    ProductId = 4,
                    Quantity = 21,
                    Date = new DateTime(2023, 12, 19),
                    TotalPrice = 16.8m,
                },
                new Transaction
                {
                    Id = 113,
                    ProductId = 7,
                    Quantity = 96,
                    Date = new DateTime(2024, 4, 14),
                    TotalPrice = 336.0m,
                },
                new Transaction
                {
                    Id = 114,
                    ProductId = 4,
                    Quantity = 75,
                    Date = new DateTime(2023, 12, 26),
                    TotalPrice = 60.0m,
                },
                new Transaction
                {
                    Id = 115,
                    ProductId = 2,
                    Quantity = 39,
                    Date = new DateTime(2024, 7, 8),
                    TotalPrice = 46.8m,
                },
                new Transaction
                {
                    Id = 116,
                    ProductId = 5,
                    Quantity = 92,
                    Date = new DateTime(2023, 11, 18),
                    TotalPrice = 9.2m,
                },
                new Transaction
                {
                    Id = 117,
                    ProductId = 8,
                    Quantity = 38,
                    Date = new DateTime(2024, 1, 21),
                    TotalPrice = 57.0m,
                },
                new Transaction
                {
                    Id = 118,
                    ProductId = 7,
                    Quantity = 85,
                    Date = new DateTime(2024, 3, 16),
                    TotalPrice = 297.5m,
                },
                new Transaction
                {
                    Id = 119,
                    ProductId = 2,
                    Quantity = 29,
                    Date = new DateTime(2024, 2, 21),
                    TotalPrice = 34.8m,
                },
                new Transaction
                {
                    Id = 120,
                    ProductId = 1,
                    Quantity = 85,
                    Date = new DateTime(2024, 2, 9),
                    TotalPrice = 212.5m,
                },
                new Transaction
                {
                    Id = 121,
                    ProductId = 1,
                    Quantity = 60,
                    Date = new DateTime(2024, 8, 17),
                    TotalPrice = 150.0m,
                },
                new Transaction
                {
                    Id = 122,
                    ProductId = 10,
                    Quantity = 24,
                    Date = new DateTime(2024, 5, 1),
                    TotalPrice = 21.6m,
                },
                new Transaction
                {
                    Id = 123,
                    ProductId = 3,
                    Quantity = 74,
                    Date = new DateTime(2023, 11, 8),
                    TotalPrice = 74.0m,
                },
                new Transaction
                {
                    Id = 124,
                    ProductId = 9,
                    Quantity = 73,
                    Date = new DateTime(2024, 2, 16),
                    TotalPrice = 365.0m,
                },
                new Transaction
                {
                    Id = 125,
                    ProductId = 6,
                    Quantity = 99,
                    Date = new DateTime(2023, 11, 18),
                    TotalPrice = 198.0m,
                },
                new Transaction
                {
                    Id = 126,
                    ProductId = 7,
                    Quantity = 84,
                    Date = new DateTime(2024, 8, 17),
                    TotalPrice = 294.0m,
                },
                new Transaction
                {
                    Id = 127,
                    ProductId = 7,
                    Quantity = 94,
                    Date = new DateTime(2024, 3, 1),
                    TotalPrice = 329.0m,
                },
                new Transaction
                {
                    Id = 128,
                    ProductId = 9,
                    Quantity = 43,
                    Date = new DateTime(2024, 6, 17),
                    TotalPrice = 215.0m,
                },
                new Transaction
                {
                    Id = 129,
                    ProductId = 6,
                    Quantity = 8,
                    Date = new DateTime(2024, 8, 16),
                    TotalPrice = 16.0m,
                },
                new Transaction
                {
                    Id = 130,
                    ProductId = 1,
                    Quantity = 18,
                    Date = new DateTime(2023, 11, 26),
                    TotalPrice = 45.0m,
                },
                new Transaction
                {
                    Id = 131,
                    ProductId = 2,
                    Quantity = 58,
                    Date = new DateTime(2024, 9, 18),
                    TotalPrice = 69.6m,
                },
                new Transaction
                {
                    Id = 132,
                    ProductId = 9,
                    Quantity = 31,
                    Date = new DateTime(2024, 8, 31),
                    TotalPrice = 155.0m,
                },
                new Transaction
                {
                    Id = 133,
                    ProductId = 7,
                    Quantity = 16,
                    Date = new DateTime(2024, 9, 3),
                    TotalPrice = 56.0m,
                },
                new Transaction
                {
                    Id = 134,
                    ProductId = 9,
                    Quantity = 25,
                    Date = new DateTime(2024, 8, 24),
                    TotalPrice = 125.0m,
                },
                new Transaction
                {
                    Id = 135,
                    ProductId = 10,
                    Quantity = 93,
                    Date = new DateTime(2024, 3, 5),
                    TotalPrice = 83.7m,
                },
                new Transaction
                {
                    Id = 136,
                    ProductId = 1,
                    Quantity = 7,
                    Date = new DateTime(2023, 12, 18),
                    TotalPrice = 17.5m,
                },
                new Transaction
                {
                    Id = 137,
                    ProductId = 7,
                    Quantity = 56,
                    Date = new DateTime(2024, 5, 15),
                    TotalPrice = 196.0m,
                },
                new Transaction
                {
                    Id = 138,
                    ProductId = 5,
                    Quantity = 40,
                    Date = new DateTime(2023, 11, 30),
                    TotalPrice = 4.0m,
                },
                new Transaction
                {
                    Id = 139,
                    ProductId = 1,
                    Quantity = 20,
                    Date = new DateTime(2024, 8, 29),
                    TotalPrice = 50.0m,
                },
                new Transaction
                {
                    Id = 140,
                    ProductId = 9,
                    Quantity = 38,
                    Date = new DateTime(2024, 8, 30),
                    TotalPrice = 190.0m,
                },
                new Transaction
                {
                    Id = 141,
                    ProductId = 3,
                    Quantity = 17,
                    Date = new DateTime(2024, 4, 6),
                    TotalPrice = 17.0m,
                },
                new Transaction
                {
                    Id = 142,
                    ProductId = 1,
                    Quantity = 70,
                    Date = new DateTime(2024, 9, 1),
                    TotalPrice = 175.0m,
                },
                new Transaction
                {
                    Id = 143,
                    ProductId = 6,
                    Quantity = 72,
                    Date = new DateTime(2024, 2, 22),
                    TotalPrice = 144.0m,
                },
                new Transaction
                {
                    Id = 144,
                    ProductId = 8,
                    Quantity = 97,
                    Date = new DateTime(2024, 2, 24),
                    TotalPrice = 145.5m,
                },
                new Transaction
                {
                    Id = 145,
                    ProductId = 1,
                    Quantity = 85,
                    Date = new DateTime(2024, 2, 19),
                    TotalPrice = 212.5m,
                },
                new Transaction
                {
                    Id = 146,
                    ProductId = 5,
                    Quantity = 91,
                    Date = new DateTime(2024, 4, 29),
                    TotalPrice = 9.1m,
                },
                new Transaction
                {
                    Id = 147,
                    ProductId = 8,
                    Quantity = 51,
                    Date = new DateTime(2024, 10, 23),
                    TotalPrice = 76.5m,
                },
                new Transaction
                {
                    Id = 148,
                    ProductId = 4,
                    Quantity = 42,
                    Date = new DateTime(2024, 3, 12),
                    TotalPrice = 33.6m,
                },
                new Transaction
                {
                    Id = 149,
                    ProductId = 5,
                    Quantity = 69,
                    Date = new DateTime(2024, 8, 24),
                    TotalPrice = 6.9m,
                },
                new Transaction
                {
                    Id = 150,
                    ProductId = 2,
                    Quantity = 77,
                    Date = new DateTime(2024, 9, 17),
                    TotalPrice = 92.4m,
                },
                new Transaction
                {
                    Id = 151,
                    ProductId = 10,
                    Quantity = 81,
                    Date = new DateTime(2024, 1, 18),
                    TotalPrice = 72.9m,
                },
                new Transaction
                {
                    Id = 152,
                    ProductId = 10,
                    Quantity = 53,
                    Date = new DateTime(2024, 9, 30),
                    TotalPrice = 47.7m,
                },
                new Transaction
                {
                    Id = 153,
                    ProductId = 7,
                    Quantity = 93,
                    Date = new DateTime(2024, 8, 3),
                    TotalPrice = 325.5m,
                },
                new Transaction
                {
                    Id = 154,
                    ProductId = 5,
                    Quantity = 49,
                    Date = new DateTime(2024, 6, 23),
                    TotalPrice = 4.9m,
                },
                new Transaction
                {
                    Id = 155,
                    ProductId = 2,
                    Quantity = 90,
                    Date = new DateTime(2024, 3, 28),
                    TotalPrice = 108.0m,
                },
                new Transaction
                {
                    Id = 156,
                    ProductId = 8,
                    Quantity = 45,
                    Date = new DateTime(2024, 4, 9),
                    TotalPrice = 67.5m,
                },
                new Transaction
                {
                    Id = 157,
                    ProductId = 3,
                    Quantity = 58,
                    Date = new DateTime(2024, 7, 13),
                    TotalPrice = 58.0m,
                },
                new Transaction
                {
                    Id = 158,
                    ProductId = 7,
                    Quantity = 12,
                    Date = new DateTime(2023, 12, 12),
                    TotalPrice = 42.0m,
                },
                new Transaction
                {
                    Id = 159,
                    ProductId = 2,
                    Quantity = 96,
                    Date = new DateTime(2024, 1, 29),
                    TotalPrice = 115.2m,
                },
                new Transaction
                {
                    Id = 160,
                    ProductId = 10,
                    Quantity = 59,
                    Date = new DateTime(2024, 10, 26),
                    TotalPrice = 53.1m,
                },
                new Transaction
                {
                    Id = 161,
                    ProductId = 10,
                    Quantity = 40,
                    Date = new DateTime(2023, 11, 14),
                    TotalPrice = 36.0m,
                },
                new Transaction
                {
                    Id = 162,
                    ProductId = 6,
                    Quantity = 80,
                    Date = new DateTime(2024, 8, 31),
                    TotalPrice = 160.0m,
                },
                new Transaction
                {
                    Id = 163,
                    ProductId = 9,
                    Quantity = 6,
                    Date = new DateTime(2024, 7, 2),
                    TotalPrice = 30.0m,
                },
                new Transaction
                {
                    Id = 164,
                    ProductId = 7,
                    Quantity = 87,
                    Date = new DateTime(2023, 11, 3),
                    TotalPrice = 304.5m,
                },
                new Transaction
                {
                    Id = 165,
                    ProductId = 3,
                    Quantity = 23,
                    Date = new DateTime(2024, 10, 21),
                    TotalPrice = 23.0m,
                },
                new Transaction
                {
                    Id = 166,
                    ProductId = 7,
                    Quantity = 16,
                    Date = new DateTime(2024, 4, 19),
                    TotalPrice = 56.0m,
                },
                new Transaction
                {
                    Id = 167,
                    ProductId = 1,
                    Quantity = 70,
                    Date = new DateTime(2024, 7, 29),
                    TotalPrice = 175.0m,
                },
                new Transaction
                {
                    Id = 168,
                    ProductId = 7,
                    Quantity = 98,
                    Date = new DateTime(2024, 8, 22),
                    TotalPrice = 343.0m,
                },
                new Transaction
                {
                    Id = 169,
                    ProductId = 9,
                    Quantity = 33,
                    Date = new DateTime(2024, 2, 17),
                    TotalPrice = 165.0m,
                },
                new Transaction
                {
                    Id = 170,
                    ProductId = 9,
                    Quantity = 85,
                    Date = new DateTime(2024, 4, 3),
                    TotalPrice = 425.0m,
                },
                new Transaction
                {
                    Id = 171,
                    ProductId = 4,
                    Quantity = 69,
                    Date = new DateTime(2024, 6, 25),
                    TotalPrice = 55.2m,
                },
                new Transaction
                {
                    Id = 172,
                    ProductId = 3,
                    Quantity = 52,
                    Date = new DateTime(2024, 9, 25),
                    TotalPrice = 52.0m,
                },
                new Transaction
                {
                    Id = 173,
                    ProductId = 4,
                    Quantity = 62,
                    Date = new DateTime(2024, 9, 22),
                    TotalPrice = 49.6m,
                },
                new Transaction
                {
                    Id = 174,
                    ProductId = 5,
                    Quantity = 88,
                    Date = new DateTime(2024, 6, 9),
                    TotalPrice = 8.8m,
                },
                new Transaction
                {
                    Id = 175,
                    ProductId = 3,
                    Quantity = 61,
                    Date = new DateTime(2024, 2, 9),
                    TotalPrice = 61.0m,
                },
                new Transaction
                {
                    Id = 176,
                    ProductId = 4,
                    Quantity = 41,
                    Date = new DateTime(2023, 12, 7),
                    TotalPrice = 32.8m,
                },
                new Transaction
                {
                    Id = 177,
                    ProductId = 9,
                    Quantity = 49,
                    Date = new DateTime(2024, 1, 12),
                    TotalPrice = 245.0m,
                },
                new Transaction
                {
                    Id = 178,
                    ProductId = 3,
                    Quantity = 89,
                    Date = new DateTime(2023, 12, 9),
                    TotalPrice = 89.0m,
                },
                new Transaction
                {
                    Id = 179,
                    ProductId = 8,
                    Quantity = 36,
                    Date = new DateTime(2024, 5, 28),
                    TotalPrice = 54.0m,
                },
                new Transaction
                {
                    Id = 180,
                    ProductId = 8,
                    Quantity = 75,
                    Date = new DateTime(2024, 5, 11),
                    TotalPrice = 112.5m,
                },
                new Transaction
                {
                    Id = 181,
                    ProductId = 5,
                    Quantity = 1,
                    Date = new DateTime(2024, 8, 10),
                    TotalPrice = 0.1m,
                },
                new Transaction
                {
                    Id = 182,
                    ProductId = 8,
                    Quantity = 29,
                    Date = new DateTime(2024, 8, 24),
                    TotalPrice = 43.5m,
                },
                new Transaction
                {
                    Id = 183,
                    ProductId = 7,
                    Quantity = 4,
                    Date = new DateTime(2024, 2, 11),
                    TotalPrice = 14.0m,
                },
                new Transaction
                {
                    Id = 184,
                    ProductId = 10,
                    Quantity = 28,
                    Date = new DateTime(2024, 4, 11),
                    TotalPrice = 25.2m,
                },
                new Transaction
                {
                    Id = 185,
                    ProductId = 5,
                    Quantity = 62,
                    Date = new DateTime(2024, 1, 3),
                    TotalPrice = 6.2m,
                },
                new Transaction
                {
                    Id = 186,
                    ProductId = 9,
                    Quantity = 40,
                    Date = new DateTime(2024, 6, 16),
                    TotalPrice = 200.0m,
                },
                new Transaction
                {
                    Id = 187,
                    ProductId = 5,
                    Quantity = 52,
                    Date = new DateTime(2023, 11, 24),
                    TotalPrice = 5.2m,
                },
                new Transaction
                {
                    Id = 188,
                    ProductId = 9,
                    Quantity = 4,
                    Date = new DateTime(2024, 6, 19),
                    TotalPrice = 20.0m,
                },
                new Transaction
                {
                    Id = 189,
                    ProductId = 8,
                    Quantity = 11,
                    Date = new DateTime(2024, 1, 11),
                    TotalPrice = 16.5m,
                },
                new Transaction
                {
                    Id = 190,
                    ProductId = 5,
                    Quantity = 48,
                    Date = new DateTime(2024, 8, 31),
                    TotalPrice = 4.8m,
                },
                new Transaction
                {
                    Id = 191,
                    ProductId = 7,
                    Quantity = 62,
                    Date = new DateTime(2023, 12, 17),
                    TotalPrice = 217.0m,
                },
                new Transaction
                {
                    Id = 192,
                    ProductId = 7,
                    Quantity = 97,
                    Date = new DateTime(2023, 12, 13),
                    TotalPrice = 339.5m,
                },
                new Transaction
                {
                    Id = 193,
                    ProductId = 2,
                    Quantity = 48,
                    Date = new DateTime(2024, 7, 1),
                    TotalPrice = 57.6m,
                },
                new Transaction
                {
                    Id = 194,
                    ProductId = 6,
                    Quantity = 67,
                    Date = new DateTime(2024, 6, 16),
                    TotalPrice = 134.0m,
                },
                new Transaction
                {
                    Id = 195,
                    ProductId = 2,
                    Quantity = 94,
                    Date = new DateTime(2024, 8, 13),
                    TotalPrice = 112.8m,
                },
                new Transaction
                {
                    Id = 196,
                    ProductId = 3,
                    Quantity = 80,
                    Date = new DateTime(2024, 7, 19),
                    TotalPrice = 80.0m,
                },
                new Transaction
                {
                    Id = 197,
                    ProductId = 1,
                    Quantity = 90,
                    Date = new DateTime(2023, 11, 11),
                    TotalPrice = 225.0m,
                },
                new Transaction
                {
                    Id = 198,
                    ProductId = 1,
                    Quantity = 31,
                    Date = new DateTime(2024, 8, 3),
                    TotalPrice = 77.5m,
                },
                new Transaction
                {
                    Id = 199,
                    ProductId = 6,
                    Quantity = 67,
                    Date = new DateTime(2023, 11, 11),
                    TotalPrice = 134.0m,
                },
                new Transaction
                {
                    Id = 200,
                    ProductId = 9,
                    Quantity = 98,
                    Date = new DateTime(2024, 8, 23),
                    TotalPrice = 490.0m,
                },
                new Transaction
                {
                    Id = 201,
                    ProductId = 4,
                    Quantity = 19,
                    Date = new DateTime(2024, 4, 5),
                    TotalPrice = 15.2m,
                },
                new Transaction
                {
                    Id = 202,
                    ProductId = 6,
                    Quantity = 26,
                    Date = new DateTime(2024, 3, 2),
                    TotalPrice = 52.0m,
                },
                new Transaction
                {
                    Id = 203,
                    ProductId = 7,
                    Quantity = 80,
                    Date = new DateTime(2024, 3, 5),
                    TotalPrice = 280.0m,
                },
                new Transaction
                {
                    Id = 204,
                    ProductId = 10,
                    Quantity = 70,
                    Date = new DateTime(2023, 11, 29),
                    TotalPrice = 63.0m,
                },
                new Transaction
                {
                    Id = 205,
                    ProductId = 1,
                    Quantity = 93,
                    Date = new DateTime(2023, 12, 22),
                    TotalPrice = 232.5m,
                },
                new Transaction
                {
                    Id = 206,
                    ProductId = 6,
                    Quantity = 63,
                    Date = new DateTime(2024, 9, 18),
                    TotalPrice = 126.0m,
                },
                new Transaction
                {
                    Id = 207,
                    ProductId = 2,
                    Quantity = 54,
                    Date = new DateTime(2024, 7, 6),
                    TotalPrice = 64.8m,
                },
                new Transaction
                {
                    Id = 208,
                    ProductId = 6,
                    Quantity = 39,
                    Date = new DateTime(2024, 3, 29),
                    TotalPrice = 78.0m,
                },
                new Transaction
                {
                    Id = 209,
                    ProductId = 2,
                    Quantity = 62,
                    Date = new DateTime(2024, 7, 5),
                    TotalPrice = 74.4m,
                },
                new Transaction
                {
                    Id = 210,
                    ProductId = 7,
                    Quantity = 10,
                    Date = new DateTime(2024, 7, 8),
                    TotalPrice = 35.0m,
                },
                new Transaction
                {
                    Id = 211,
                    ProductId = 10,
                    Quantity = 32,
                    Date = new DateTime(2024, 4, 28),
                    TotalPrice = 28.8m,
                },
                new Transaction
                {
                    Id = 212,
                    ProductId = 2,
                    Quantity = 17,
                    Date = new DateTime(2024, 5, 7),
                    TotalPrice = 20.4m,
                },
                new Transaction
                {
                    Id = 213,
                    ProductId = 9,
                    Quantity = 63,
                    Date = new DateTime(2024, 2, 24),
                    TotalPrice = 315.0m,
                },
                new Transaction
                {
                    Id = 214,
                    ProductId = 6,
                    Quantity = 57,
                    Date = new DateTime(2024, 10, 27),
                    TotalPrice = 114.0m,
                },
                new Transaction
                {
                    Id = 215,
                    ProductId = 7,
                    Quantity = 13,
                    Date = new DateTime(2024, 8, 18),
                    TotalPrice = 45.5m,
                },
                new Transaction
                {
                    Id = 216,
                    ProductId = 1,
                    Quantity = 2,
                    Date = new DateTime(2024, 6, 10),
                    TotalPrice = 5.0m,
                },
                new Transaction
                {
                    Id = 217,
                    ProductId = 4,
                    Quantity = 98,
                    Date = new DateTime(2024, 10, 14),
                    TotalPrice = 78.4m,
                },
                new Transaction
                {
                    Id = 218,
                    ProductId = 9,
                    Quantity = 71,
                    Date = new DateTime(2024, 5, 17),
                    TotalPrice = 355.0m,
                },
                new Transaction
                {
                    Id = 219,
                    ProductId = 9,
                    Quantity = 86,
                    Date = new DateTime(2024, 1, 8),
                    TotalPrice = 430.0m,
                },
                new Transaction
                {
                    Id = 220,
                    ProductId = 10,
                    Quantity = 36,
                    Date = new DateTime(2024, 3, 8),
                    TotalPrice = 32.4m,
                },
                new Transaction
                {
                    Id = 221,
                    ProductId = 4,
                    Quantity = 6,
                    Date = new DateTime(2024, 2, 16),
                    TotalPrice = 4.8m,
                },
                new Transaction
                {
                    Id = 222,
                    ProductId = 4,
                    Quantity = 3,
                    Date = new DateTime(2024, 6, 8),
                    TotalPrice = 2.4m,
                },
                new Transaction
                {
                    Id = 223,
                    ProductId = 5,
                    Quantity = 90,
                    Date = new DateTime(2024, 1, 23),
                    TotalPrice = 9.0m,
                },
                new Transaction
                {
                    Id = 224,
                    ProductId = 4,
                    Quantity = 76,
                    Date = new DateTime(2023, 10, 30),
                    TotalPrice = 60.8m,
                },
                new Transaction
                {
                    Id = 225,
                    ProductId = 5,
                    Quantity = 61,
                    Date = new DateTime(2023, 11, 8),
                    TotalPrice = 6.1m,
                },
                new Transaction
                {
                    Id = 226,
                    ProductId = 4,
                    Quantity = 90,
                    Date = new DateTime(2024, 7, 25),
                    TotalPrice = 72.0m,
                },
                new Transaction
                {
                    Id = 227,
                    ProductId = 4,
                    Quantity = 15,
                    Date = new DateTime(2024, 3, 21),
                    TotalPrice = 12.0m,
                },
                new Transaction
                {
                    Id = 228,
                    ProductId = 10,
                    Quantity = 25,
                    Date = new DateTime(2024, 9, 14),
                    TotalPrice = 22.5m,
                },
                new Transaction
                {
                    Id = 229,
                    ProductId = 3,
                    Quantity = 6,
                    Date = new DateTime(2024, 3, 21),
                    TotalPrice = 6.0m,
                },
                new Transaction
                {
                    Id = 230,
                    ProductId = 1,
                    Quantity = 28,
                    Date = new DateTime(2024, 7, 10),
                    TotalPrice = 70.0m,
                },
                new Transaction
                {
                    Id = 231,
                    ProductId = 7,
                    Quantity = 83,
                    Date = new DateTime(2024, 7, 21),
                    TotalPrice = 290.5m,
                },
                new Transaction
                {
                    Id = 232,
                    ProductId = 1,
                    Quantity = 21,
                    Date = new DateTime(2024, 4, 26),
                    TotalPrice = 52.5m,
                },
                new Transaction
                {
                    Id = 233,
                    ProductId = 4,
                    Quantity = 29,
                    Date = new DateTime(2024, 9, 21),
                    TotalPrice = 23.2m,
                },
                new Transaction
                {
                    Id = 234,
                    ProductId = 9,
                    Quantity = 64,
                    Date = new DateTime(2024, 9, 15),
                    TotalPrice = 320.0m,
                },
                new Transaction
                {
                    Id = 235,
                    ProductId = 7,
                    Quantity = 1,
                    Date = new DateTime(2024, 8, 9),
                    TotalPrice = 3.5m,
                },
                new Transaction
                {
                    Id = 236,
                    ProductId = 1,
                    Quantity = 43,
                    Date = new DateTime(2024, 9, 20),
                    TotalPrice = 107.5m,
                },
                new Transaction
                {
                    Id = 237,
                    ProductId = 5,
                    Quantity = 56,
                    Date = new DateTime(2023, 11, 10),
                    TotalPrice = 5.6m,
                },
                new Transaction
                {
                    Id = 238,
                    ProductId = 6,
                    Quantity = 60,
                    Date = new DateTime(2024, 8, 13),
                    TotalPrice = 120.0m,
                },
                new Transaction
                {
                    Id = 239,
                    ProductId = 1,
                    Quantity = 42,
                    Date = new DateTime(2024, 1, 5),
                    TotalPrice = 105.0m,
                },
                new Transaction
                {
                    Id = 240,
                    ProductId = 6,
                    Quantity = 8,
                    Date = new DateTime(2023, 11, 9),
                    TotalPrice = 16.0m,
                },
                new Transaction
                {
                    Id = 241,
                    ProductId = 8,
                    Quantity = 36,
                    Date = new DateTime(2024, 3, 16),
                    TotalPrice = 54.0m,
                },
                new Transaction
                {
                    Id = 242,
                    ProductId = 5,
                    Quantity = 71,
                    Date = new DateTime(2023, 11, 21),
                    TotalPrice = 7.1m,
                },
                new Transaction
                {
                    Id = 243,
                    ProductId = 8,
                    Quantity = 40,
                    Date = new DateTime(2024, 6, 5),
                    TotalPrice = 60.0m,
                },
                new Transaction
                {
                    Id = 244,
                    ProductId = 5,
                    Quantity = 1,
                    Date = new DateTime(2024, 3, 18),
                    TotalPrice = 0.1m,
                },
                new Transaction
                {
                    Id = 245,
                    ProductId = 2,
                    Quantity = 58,
                    Date = new DateTime(2024, 4, 22),
                    TotalPrice = 69.6m,
                },
                new Transaction
                {
                    Id = 246,
                    ProductId = 5,
                    Quantity = 32,
                    Date = new DateTime(2024, 8, 2),
                    TotalPrice = 3.2m,
                },
                new Transaction
                {
                    Id = 247,
                    ProductId = 10,
                    Quantity = 23,
                    Date = new DateTime(2024, 3, 8),
                    TotalPrice = 20.7m,
                },
                new Transaction
                {
                    Id = 248,
                    ProductId = 6,
                    Quantity = 58,
                    Date = new DateTime(2024, 2, 8),
                    TotalPrice = 116.0m,
                },
                new Transaction
                {
                    Id = 249,
                    ProductId = 4,
                    Quantity = 13,
                    Date = new DateTime(2024, 8, 5),
                    TotalPrice = 10.4m,
                },
                new Transaction
                {
                    Id = 250,
                    ProductId = 1,
                    Quantity = 100,
                    Date = new DateTime(2024, 1, 12),
                    TotalPrice = 250.0m,
                },
                new Transaction
                {
                    Id = 251,
                    ProductId = 7,
                    Quantity = 73,
                    Date = new DateTime(2024, 8, 14),
                    TotalPrice = 255.5m,
                },
                new Transaction
                {
                    Id = 252,
                    ProductId = 2,
                    Quantity = 3,
                    Date = new DateTime(2024, 7, 20),
                    TotalPrice = 3.6m,
                },
                new Transaction
                {
                    Id = 253,
                    ProductId = 5,
                    Quantity = 16,
                    Date = new DateTime(2024, 7, 8),
                    TotalPrice = 1.6m,
                },
                new Transaction
                {
                    Id = 254,
                    ProductId = 3,
                    Quantity = 32,
                    Date = new DateTime(2024, 10, 19),
                    TotalPrice = 32.0m,
                },
                new Transaction
                {
                    Id = 255,
                    ProductId = 8,
                    Quantity = 2,
                    Date = new DateTime(2024, 4, 8),
                    TotalPrice = 3.0m,
                },
                new Transaction
                {
                    Id = 256,
                    ProductId = 4,
                    Quantity = 39,
                    Date = new DateTime(2024, 10, 22),
                    TotalPrice = 31.2m,
                },
                new Transaction
                {
                    Id = 257,
                    ProductId = 7,
                    Quantity = 55,
                    Date = new DateTime(2024, 9, 21),
                    TotalPrice = 192.5m,
                },
                new Transaction
                {
                    Id = 258,
                    ProductId = 6,
                    Quantity = 68,
                    Date = new DateTime(2023, 12, 21),
                    TotalPrice = 136.0m,
                },
                new Transaction
                {
                    Id = 259,
                    ProductId = 4,
                    Quantity = 29,
                    Date = new DateTime(2024, 1, 16),
                    TotalPrice = 23.2m,
                },
                new Transaction
                {
                    Id = 260,
                    ProductId = 9,
                    Quantity = 13,
                    Date = new DateTime(2024, 3, 31),
                    TotalPrice = 65.0m,
                },
                new Transaction
                {
                    Id = 261,
                    ProductId = 8,
                    Quantity = 67,
                    Date = new DateTime(2024, 6, 4),
                    TotalPrice = 100.5m,
                },
                new Transaction
                {
                    Id = 262,
                    ProductId = 7,
                    Quantity = 78,
                    Date = new DateTime(2024, 7, 18),
                    TotalPrice = 273.0m,
                },
                new Transaction
                {
                    Id = 263,
                    ProductId = 5,
                    Quantity = 3,
                    Date = new DateTime(2024, 4, 9),
                    TotalPrice = 0.3m,
                },
                new Transaction
                {
                    Id = 264,
                    ProductId = 3,
                    Quantity = 99,
                    Date = new DateTime(2024, 8, 30),
                    TotalPrice = 99.0m,
                },
                new Transaction
                {
                    Id = 265,
                    ProductId = 10,
                    Quantity = 62,
                    Date = new DateTime(2023, 11, 30),
                    TotalPrice = 55.8m,
                },
                new Transaction
                {
                    Id = 266,
                    ProductId = 7,
                    Quantity = 80,
                    Date = new DateTime(2024, 4, 3),
                    TotalPrice = 280.0m,
                },
                new Transaction
                {
                    Id = 267,
                    ProductId = 2,
                    Quantity = 99,
                    Date = new DateTime(2024, 1, 31),
                    TotalPrice = 118.8m,
                },
                new Transaction
                {
                    Id = 268,
                    ProductId = 3,
                    Quantity = 38,
                    Date = new DateTime(2024, 5, 15),
                    TotalPrice = 38.0m,
                },
                new Transaction
                {
                    Id = 269,
                    ProductId = 7,
                    Quantity = 12,
                    Date = new DateTime(2024, 10, 10),
                    TotalPrice = 42.0m,
                },
                new Transaction
                {
                    Id = 270,
                    ProductId = 4,
                    Quantity = 80,
                    Date = new DateTime(2024, 1, 29),
                    TotalPrice = 64.0m,
                },
                new Transaction
                {
                    Id = 271,
                    ProductId = 5,
                    Quantity = 60,
                    Date = new DateTime(2024, 10, 17),
                    TotalPrice = 6.0m,
                },
                new Transaction
                {
                    Id = 272,
                    ProductId = 8,
                    Quantity = 58,
                    Date = new DateTime(2024, 3, 4),
                    TotalPrice = 87.0m,
                },
                new Transaction
                {
                    Id = 273,
                    ProductId = 7,
                    Quantity = 11,
                    Date = new DateTime(2024, 8, 2),
                    TotalPrice = 38.5m,
                },
                new Transaction
                {
                    Id = 274,
                    ProductId = 3,
                    Quantity = 95,
                    Date = new DateTime(2024, 6, 19),
                    TotalPrice = 95.0m,
                },
                new Transaction
                {
                    Id = 275,
                    ProductId = 5,
                    Quantity = 45,
                    Date = new DateTime(2024, 4, 7),
                    TotalPrice = 4.5m,
                },
                new Transaction
                {
                    Id = 276,
                    ProductId = 10,
                    Quantity = 65,
                    Date = new DateTime(2024, 10, 5),
                    TotalPrice = 58.5m,
                },
                new Transaction
                {
                    Id = 277,
                    ProductId = 10,
                    Quantity = 72,
                    Date = new DateTime(2024, 5, 2),
                    TotalPrice = 64.8m,
                },
                new Transaction
                {
                    Id = 278,
                    ProductId = 3,
                    Quantity = 74,
                    Date = new DateTime(2024, 9, 5),
                    TotalPrice = 74.0m,
                },
                new Transaction
                {
                    Id = 279,
                    ProductId = 9,
                    Quantity = 50,
                    Date = new DateTime(2024, 7, 13),
                    TotalPrice = 250.0m,
                },
                new Transaction
                {
                    Id = 280,
                    ProductId = 10,
                    Quantity = 91,
                    Date = new DateTime(2024, 3, 2),
                    TotalPrice = 81.9m,
                },
                new Transaction
                {
                    Id = 281,
                    ProductId = 3,
                    Quantity = 6,
                    Date = new DateTime(2024, 8, 5),
                    TotalPrice = 6.0m,
                },
                new Transaction
                {
                    Id = 282,
                    ProductId = 9,
                    Quantity = 76,
                    Date = new DateTime(2024, 6, 8),
                    TotalPrice = 380.0m,
                },
                new Transaction
                {
                    Id = 283,
                    ProductId = 2,
                    Quantity = 20,
                    Date = new DateTime(2024, 10, 12),
                    TotalPrice = 24.0m,
                },
                new Transaction
                {
                    Id = 284,
                    ProductId = 3,
                    Quantity = 100,
                    Date = new DateTime(2024, 2, 20),
                    TotalPrice = 100.0m,
                },
                new Transaction
                {
                    Id = 285,
                    ProductId = 4,
                    Quantity = 89,
                    Date = new DateTime(2024, 10, 12),
                    TotalPrice = 71.2m,
                },
                new Transaction
                {
                    Id = 286,
                    ProductId = 4,
                    Quantity = 76,
                    Date = new DateTime(2023, 11, 25),
                    TotalPrice = 60.8m,
                },
                new Transaction
                {
                    Id = 287,
                    ProductId = 9,
                    Quantity = 76,
                    Date = new DateTime(2024, 5, 8),
                    TotalPrice = 380.0m,
                },
                new Transaction
                {
                    Id = 288,
                    ProductId = 10,
                    Quantity = 41,
                    Date = new DateTime(2024, 9, 26),
                    TotalPrice = 36.9m,
                },
                new Transaction
                {
                    Id = 289,
                    ProductId = 3,
                    Quantity = 28,
                    Date = new DateTime(2023, 12, 17),
                    TotalPrice = 28.0m,
                },
                new Transaction
                {
                    Id = 290,
                    ProductId = 9,
                    Quantity = 90,
                    Date = new DateTime(2024, 9, 27),
                    TotalPrice = 450.0m,
                },
                new Transaction
                {
                    Id = 291,
                    ProductId = 4,
                    Quantity = 68,
                    Date = new DateTime(2024, 8, 17),
                    TotalPrice = 54.4m,
                },
                new Transaction
                {
                    Id = 292,
                    ProductId = 6,
                    Quantity = 5,
                    Date = new DateTime(2023, 12, 10),
                    TotalPrice = 10.0m,
                },
                new Transaction
                {
                    Id = 293,
                    ProductId = 2,
                    Quantity = 66,
                    Date = new DateTime(2024, 2, 16),
                    TotalPrice = 79.2m,
                },
                new Transaction
                {
                    Id = 294,
                    ProductId = 2,
                    Quantity = 81,
                    Date = new DateTime(2024, 5, 17),
                    TotalPrice = 97.2m,
                },
                new Transaction
                {
                    Id = 295,
                    ProductId = 1,
                    Quantity = 69,
                    Date = new DateTime(2024, 2, 8),
                    TotalPrice = 172.5m,
                },
                new Transaction
                {
                    Id = 296,
                    ProductId = 9,
                    Quantity = 89,
                    Date = new DateTime(2023, 12, 23),
                    TotalPrice = 445.0m,
                },
                new Transaction
                {
                    Id = 297,
                    ProductId = 2,
                    Quantity = 46,
                    Date = new DateTime(2024, 2, 1),
                    TotalPrice = 55.2m,
                },
                new Transaction
                {
                    Id = 298,
                    ProductId = 4,
                    Quantity = 6,
                    Date = new DateTime(2024, 9, 1),
                    TotalPrice = 4.8m,
                },
                new Transaction
                {
                    Id = 299,
                    ProductId = 2,
                    Quantity = 25,
                    Date = new DateTime(2024, 3, 4),
                    TotalPrice = 30.0m,
                },
                new Transaction
                {
                    Id = 300,
                    ProductId = 2,
                    Quantity = 56,
                    Date = new DateTime(2024, 5, 8),
                    TotalPrice = 67.2m,
                },
                new Transaction
                {
                    Id = 301,
                    ProductId = 6,
                    Quantity = 25,
                    Date = new DateTime(2024, 7, 8),
                    TotalPrice = 50.0m,
                },
                new Transaction
                {
                    Id = 302,
                    ProductId = 10,
                    Quantity = 91,
                    Date = new DateTime(2024, 7, 4),
                    TotalPrice = 81.9m,
                },
                new Transaction
                {
                    Id = 303,
                    ProductId = 5,
                    Quantity = 75,
                    Date = new DateTime(2023, 12, 24),
                    TotalPrice = 7.5m,
                },
                new Transaction
                {
                    Id = 304,
                    ProductId = 2,
                    Quantity = 26,
                    Date = new DateTime(2024, 9, 21),
                    TotalPrice = 31.2m,
                },
                new Transaction
                {
                    Id = 305,
                    ProductId = 3,
                    Quantity = 73,
                    Date = new DateTime(2023, 11, 17),
                    TotalPrice = 73.0m,
                },
                new Transaction
                {
                    Id = 306,
                    ProductId = 1,
                    Quantity = 97,
                    Date = new DateTime(2024, 2, 5),
                    TotalPrice = 242.5m,
                },
                new Transaction
                {
                    Id = 307,
                    ProductId = 4,
                    Quantity = 46,
                    Date = new DateTime(2024, 6, 6),
                    TotalPrice = 36.8m,
                },
                new Transaction
                {
                    Id = 308,
                    ProductId = 1,
                    Quantity = 79,
                    Date = new DateTime(2024, 5, 20),
                    TotalPrice = 197.5m,
                },
                new Transaction
                {
                    Id = 309,
                    ProductId = 4,
                    Quantity = 100,
                    Date = new DateTime(2024, 3, 13),
                    TotalPrice = 80.0m,
                },
                new Transaction
                {
                    Id = 310,
                    ProductId = 1,
                    Quantity = 40,
                    Date = new DateTime(2024, 1, 11),
                    TotalPrice = 100.0m,
                },
                new Transaction
                {
                    Id = 311,
                    ProductId = 3,
                    Quantity = 99,
                    Date = new DateTime(2024, 9, 20),
                    TotalPrice = 99.0m,
                },
                new Transaction
                {
                    Id = 312,
                    ProductId = 3,
                    Quantity = 65,
                    Date = new DateTime(2024, 4, 6),
                    TotalPrice = 65.0m,
                },
                new Transaction
                {
                    Id = 313,
                    ProductId = 2,
                    Quantity = 7,
                    Date = new DateTime(2024, 1, 17),
                    TotalPrice = 8.4m,
                },
                new Transaction
                {
                    Id = 314,
                    ProductId = 5,
                    Quantity = 32,
                    Date = new DateTime(2024, 9, 7),
                    TotalPrice = 3.2m,
                },
                new Transaction
                {
                    Id = 315,
                    ProductId = 1,
                    Quantity = 95,
                    Date = new DateTime(2024, 8, 14),
                    TotalPrice = 237.5m,
                },
                new Transaction
                {
                    Id = 316,
                    ProductId = 7,
                    Quantity = 14,
                    Date = new DateTime(2024, 6, 30),
                    TotalPrice = 49.0m,
                },
                new Transaction
                {
                    Id = 317,
                    ProductId = 3,
                    Quantity = 16,
                    Date = new DateTime(2024, 7, 17),
                    TotalPrice = 16.0m,
                },
                new Transaction
                {
                    Id = 318,
                    ProductId = 10,
                    Quantity = 78,
                    Date = new DateTime(2024, 9, 23),
                    TotalPrice = 70.2m,
                },
                new Transaction
                {
                    Id = 319,
                    ProductId = 1,
                    Quantity = 51,
                    Date = new DateTime(2024, 5, 11),
                    TotalPrice = 127.5m,
                },
                new Transaction
                {
                    Id = 320,
                    ProductId = 9,
                    Quantity = 62,
                    Date = new DateTime(2023, 12, 2),
                    TotalPrice = 310.0m,
                },
                new Transaction
                {
                    Id = 321,
                    ProductId = 7,
                    Quantity = 45,
                    Date = new DateTime(2024, 6, 22),
                    TotalPrice = 157.5m,
                },
                new Transaction
                {
                    Id = 322,
                    ProductId = 1,
                    Quantity = 93,
                    Date = new DateTime(2024, 7, 23),
                    TotalPrice = 232.5m,
                },
                new Transaction
                {
                    Id = 323,
                    ProductId = 10,
                    Quantity = 1,
                    Date = new DateTime(2024, 9, 29),
                    TotalPrice = 0.9m,
                },
                new Transaction
                {
                    Id = 324,
                    ProductId = 4,
                    Quantity = 89,
                    Date = new DateTime(2023, 12, 3),
                    TotalPrice = 71.2m,
                },
                new Transaction
                {
                    Id = 325,
                    ProductId = 10,
                    Quantity = 97,
                    Date = new DateTime(2024, 9, 4),
                    TotalPrice = 87.3m,
                },
                new Transaction
                {
                    Id = 326,
                    ProductId = 3,
                    Quantity = 2,
                    Date = new DateTime(2023, 12, 25),
                    TotalPrice = 2.0m,
                },
                new Transaction
                {
                    Id = 327,
                    ProductId = 3,
                    Quantity = 71,
                    Date = new DateTime(2023, 12, 20),
                    TotalPrice = 71.0m,
                },
                new Transaction
                {
                    Id = 328,
                    ProductId = 3,
                    Quantity = 84,
                    Date = new DateTime(2024, 8, 1),
                    TotalPrice = 84.0m,
                },
                new Transaction
                {
                    Id = 329,
                    ProductId = 6,
                    Quantity = 31,
                    Date = new DateTime(2024, 8, 12),
                    TotalPrice = 62.0m,
                },
                new Transaction
                {
                    Id = 330,
                    ProductId = 1,
                    Quantity = 15,
                    Date = new DateTime(2024, 9, 7),
                    TotalPrice = 37.5m,
                },
                new Transaction
                {
                    Id = 331,
                    ProductId = 1,
                    Quantity = 28,
                    Date = new DateTime(2024, 5, 16),
                    TotalPrice = 70.0m,
                },
                new Transaction
                {
                    Id = 332,
                    ProductId = 9,
                    Quantity = 72,
                    Date = new DateTime(2023, 12, 18),
                    TotalPrice = 360.0m,
                },
                new Transaction
                {
                    Id = 333,
                    ProductId = 8,
                    Quantity = 96,
                    Date = new DateTime(2024, 10, 22),
                    TotalPrice = 144.0m,
                },
                new Transaction
                {
                    Id = 334,
                    ProductId = 10,
                    Quantity = 64,
                    Date = new DateTime(2024, 9, 7),
                    TotalPrice = 57.6m,
                },
                new Transaction
                {
                    Id = 335,
                    ProductId = 3,
                    Quantity = 83,
                    Date = new DateTime(2024, 7, 18),
                    TotalPrice = 83.0m,
                },
                new Transaction
                {
                    Id = 336,
                    ProductId = 4,
                    Quantity = 98,
                    Date = new DateTime(2024, 1, 4),
                    TotalPrice = 78.4m,
                },
                new Transaction
                {
                    Id = 337,
                    ProductId = 10,
                    Quantity = 83,
                    Date = new DateTime(2024, 5, 1),
                    TotalPrice = 74.7m,
                },
                new Transaction
                {
                    Id = 338,
                    ProductId = 7,
                    Quantity = 63,
                    Date = new DateTime(2023, 12, 3),
                    TotalPrice = 220.5m,
                },
                new Transaction
                {
                    Id = 339,
                    ProductId = 1,
                    Quantity = 40,
                    Date = new DateTime(2024, 3, 17),
                    TotalPrice = 100.0m,
                },
                new Transaction
                {
                    Id = 340,
                    ProductId = 2,
                    Quantity = 54,
                    Date = new DateTime(2024, 3, 15),
                    TotalPrice = 64.8m,
                },
                new Transaction
                {
                    Id = 341,
                    ProductId = 1,
                    Quantity = 100,
                    Date = new DateTime(2023, 12, 21),
                    TotalPrice = 250.0m,
                },
                new Transaction
                {
                    Id = 342,
                    ProductId = 10,
                    Quantity = 30,
                    Date = new DateTime(2024, 3, 21),
                    TotalPrice = 27.0m,
                },
                new Transaction
                {
                    Id = 343,
                    ProductId = 5,
                    Quantity = 8,
                    Date = new DateTime(2024, 7, 29),
                    TotalPrice = 0.8m,
                },
                new Transaction
                {
                    Id = 344,
                    ProductId = 3,
                    Quantity = 47,
                    Date = new DateTime(2024, 10, 6),
                    TotalPrice = 47.0m,
                },
                new Transaction
                {
                    Id = 345,
                    ProductId = 9,
                    Quantity = 30,
                    Date = new DateTime(2024, 10, 2),
                    TotalPrice = 150.0m,
                },
                new Transaction
                {
                    Id = 346,
                    ProductId = 8,
                    Quantity = 5,
                    Date = new DateTime(2024, 10, 22),
                    TotalPrice = 7.5m,
                },
                new Transaction
                {
                    Id = 347,
                    ProductId = 10,
                    Quantity = 14,
                    Date = new DateTime(2024, 6, 28),
                    TotalPrice = 12.6m,
                },
                new Transaction
                {
                    Id = 348,
                    ProductId = 4,
                    Quantity = 6,
                    Date = new DateTime(2024, 7, 1),
                    TotalPrice = 4.8m,
                },
                new Transaction
                {
                    Id = 349,
                    ProductId = 7,
                    Quantity = 48,
                    Date = new DateTime(2024, 3, 4),
                    TotalPrice = 168.0m,
                },
                new Transaction
                {
                    Id = 350,
                    ProductId = 6,
                    Quantity = 83,
                    Date = new DateTime(2024, 7, 3),
                    TotalPrice = 166.0m,
                },
                new Transaction
                {
                    Id = 351,
                    ProductId = 3,
                    Quantity = 68,
                    Date = new DateTime(2024, 5, 26),
                    TotalPrice = 68.0m,
                },
                new Transaction
                {
                    Id = 352,
                    ProductId = 4,
                    Quantity = 89,
                    Date = new DateTime(2024, 3, 5),
                    TotalPrice = 71.2m,
                },
                new Transaction
                {
                    Id = 353,
                    ProductId = 3,
                    Quantity = 31,
                    Date = new DateTime(2024, 4, 17),
                    TotalPrice = 31.0m,
                },
                new Transaction
                {
                    Id = 354,
                    ProductId = 7,
                    Quantity = 93,
                    Date = new DateTime(2023, 12, 3),
                    TotalPrice = 325.5m,
                }
            );
        }
    }
}
