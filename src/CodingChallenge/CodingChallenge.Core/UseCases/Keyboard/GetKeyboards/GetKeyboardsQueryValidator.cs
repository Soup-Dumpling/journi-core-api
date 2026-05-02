using FluentValidation;

namespace Journi.CodingChallenge.Core.UseCases.Keyboard.GetKeyboards
{
    public class GetKeyboardsQueryValidator : AbstractValidator<GetKeyboardsQuery>
    {
        public GetKeyboardsQueryValidator() 
        {
            RuleFor(x => x.PageSize).GreaterThan(0);
        }
    }
}
