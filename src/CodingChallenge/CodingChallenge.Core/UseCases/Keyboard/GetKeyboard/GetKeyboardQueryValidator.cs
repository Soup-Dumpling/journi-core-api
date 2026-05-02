using FluentValidation;

namespace Journi.CodingChallenge.Core.UseCases.Keyboard.GetKeyboard
{
    public class GetKeyboardQueryValidator : AbstractValidator<GetKeyboardQuery>
    {
        public GetKeyboardQueryValidator() 
        {
            RuleFor(x => x.Id).NotEmpty();
        }
    }
}
