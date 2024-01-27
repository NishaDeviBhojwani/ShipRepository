using API.Domain;
using FluentValidation;

namespace API.Validator
{
    public class ShipValidator : AbstractValidator<Ship>
    {
        public ShipValidator()
        {
            RuleFor(x => x.Id).NotNull();
            RuleFor(x => x.Name).Length(0, 255);
            RuleFor(x => x.Code).Matches("^([A-Za-z]){4}-([0-9]){4}-[A-Za-z][0-9]$");
            RuleFor(x => x.Length).GreaterThan(0);
            RuleFor(x => x.Width).GreaterThan(0);
        }
    }
}
