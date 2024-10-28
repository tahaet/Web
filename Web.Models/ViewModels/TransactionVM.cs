using Microsoft.AspNetCore.Mvc.Rendering;

namespace Web.Models.ViewModels
{
    public class TransactionVM
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTime Date { get; set; } = DateTime.UtcNow;
        public decimal TotalPrice { get; set; }
        public int UnitId { get; set; }
        public string UnitName { get; set; }
        public decimal Price { get; set; }
        public IEnumerable<SelectListItem> ProductList { get; set; }
        public IEnumerable<SelectListItem> UnitList { get; set; }
    }
}
