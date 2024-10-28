using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Web.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int UnitId { get; set; }
        [ValidateNever]
        public Unit Unit { get; set; }
        public decimal Price { get; set; }
        public int InitialQuantity { get; set; }
    }
}
