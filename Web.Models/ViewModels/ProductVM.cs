using Microsoft.AspNetCore.Mvc.Rendering;

namespace Web.Models.ViewModels
{
    public class ProductVM
    {
        public Product Product { get; set; }

        public IEnumerable<SelectListItem> UnitList { get; set; }
    }
}
