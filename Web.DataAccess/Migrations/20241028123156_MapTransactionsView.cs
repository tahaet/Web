using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class MapTransactionsView : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
            CREATE VIEW [dbo].[TransactionsView] AS
            SELECT 
                dbo.Products.Name AS ProductName,
                dbo.Transactions.Quantity,
                dbo.Units.Name AS UnitName,
                dbo.Transactions.TotalPrice,
                dbo.Transactions.Date
            FROM 
                dbo.Products 
            INNER JOIN 
                dbo.Transactions ON dbo.Products.Id = dbo.Transactions.ProductId
            INNER JOIN 
                dbo.Units ON dbo.Units.Id = dbo.Products.UnitId;
        ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
