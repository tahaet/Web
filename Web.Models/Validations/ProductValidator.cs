using FluentValidation;

namespace Web.Models.Validations
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.Price)
               .GreaterThan(0)
               .WithMessage("Price must be greater than 0.");

            RuleFor(product => product.InitialQuantity)
                .GreaterThan(0)
                .WithMessage("Quantity must be greater than 0.")
                .WithName("Initial Quantity");

        }
    }
}
