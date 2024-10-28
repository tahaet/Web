using FluentValidation;
using Web.Models.ViewModels;

namespace Web.Models.Validations
{
    public class TransactionVMValidator : AbstractValidator<TransactionVM>
    {
        public TransactionVMValidator()
        {
            RuleFor(x => x.Quantity)
                .NotEmpty()
                .WithMessage("Quantity can't be 0")
                .GreaterThan(0)
                .WithMessage("Quantity can't be 0");

            RuleFor(x => x.ProductId)
                .NotNull()
                .WithMessage("You must choose a product")
                .NotEmpty()
                .WithMessage("You must choose a product");
            RuleFor(x => x.Date).NotEmpty().WithMessage("Date can't be empty");

            RuleFor(x => x.TotalPrice)
                .NotEmpty()
                .WithMessage("Total price can't be empty")
                .GreaterThan(0)
                .WithMessage("Total price must be greater than 0")
                .WithName("Total Price");
        }
    }
}
