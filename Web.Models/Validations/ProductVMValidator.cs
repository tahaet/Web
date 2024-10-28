using FluentValidation;
using Web.Models.ViewModels;

namespace Web.Models.Validations
{
    public class ProductVMValidator : AbstractValidator<ProductVM>
    {
        public ProductVMValidator()
        {
            RuleFor(x => x.Product)
            .SetValidator(new ProductValidator());
            RuleFor(x => x.UnitList)
                .Must(unitList => unitList == null || !unitList.Any())
                .WithMessage("UnitList must be either null or empty.");
        }
    }
}
