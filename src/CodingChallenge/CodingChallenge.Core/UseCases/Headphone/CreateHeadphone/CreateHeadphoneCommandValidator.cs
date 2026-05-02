using FluentValidation;

namespace Journi.CodingChallenge.Core.UseCases.Headphone.CreateHeadphone
{
    public class CreateHeadphoneCommandValidator : AbstractValidator<CreateHeadphoneCommand>
    {
        public CreateHeadphoneCommandValidator()
        {
            RuleFor(x => x.BatteryLife).NotEmpty();
            RuleFor(x => x.Color).NotEmpty();
            RuleFor(x => x.Description).NotEmpty();
            RuleFor(x => x.ImageFileName).NotEmpty();
            RuleFor(x => x.Manufacturer).NotEmpty();
            RuleFor(x => x.Mic).NotNull();
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.NoiseCancellationType).NotEmpty();
            RuleFor(x => x.Price).NotEmpty().GreaterThan(0);
            RuleFor(x => x.ReleaseDate).NotEmpty();
            RuleFor(x => x.Type).NotEmpty();
            RuleFor(x => x.Weight).NotEmpty();
            RuleFor(x => x.Wireless).NotNull();
        }
    }
}
