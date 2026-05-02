using FluentValidation;

namespace Journi.CodingChallenge.Core.UseCases.Headphone.GetHeadphones
{
    public class GetHeadphonesQueryValidator : AbstractValidator<GetHeadphonesQuery>
    {
        public GetHeadphonesQueryValidator()
        {
            RuleFor(x => x.PageSize).GreaterThan(0);
        }
    }
}
