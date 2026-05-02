using FluentValidation;

namespace Journi.CodingChallenge.Core.UseCases.Headphone.GetHeadphone
{
    public class GetHeadphoneQueryValidator : AbstractValidator<GetHeadphoneQuery>
    {
        public GetHeadphoneQueryValidator() 
        {
            RuleFor(x => x.Id).NotEmpty();
        }
    }
}
