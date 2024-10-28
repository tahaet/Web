namespace Web.Models;

public class Transaction
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public Product Product { get; set; }
    public int Quantity { get; set; }
    public DateTime Date { get; set; } = DateTime.Now;

    public decimal TotalPrice { get; set; }

    public Transaction()
    {
        if (Product is not null)
            TotalPrice = Product.Price * Quantity;
    }
}
