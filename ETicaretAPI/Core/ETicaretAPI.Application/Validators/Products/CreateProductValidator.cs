using ETicaretAPI.Application.ViewModels.Products;
using FluentValidation;

namespace ETicaretAPI.Application.Validators.Products
{
    public class CreateProductValidator : AbstractValidator<VM_Create_Product>
    {

        public CreateProductValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty()
                .NotNull()
                .WithMessage("pls write something for name of product")
                .MaximumLength(150)
                .MinimumLength(5)
                .WithMessage("write correctly");


            RuleFor(p => p.Stock)
                .NotEmpty()
                .NotNull()
                .WithMessage("dfb")
                .Must(s => s >= 0)
                .WithMessage("drbg");


            RuleFor(s => s.Price)
                .NotEmpty()
                .NotNull()
                .WithMessage("dfb")
                .Must(s => s >= 0)
                .WithMessage("dfb");




        }
    }
}
