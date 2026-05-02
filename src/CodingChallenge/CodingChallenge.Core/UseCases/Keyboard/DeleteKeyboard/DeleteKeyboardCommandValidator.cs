using FluentValidation;

namespace Journi.CodingChallenge.Core.UseCases.Keyboard.DeleteKeyboard
{
    public class DeleteKeyboardCommandValidator : AbstractValidator<DeleteKeyboardCommand>
    {
        public DeleteKeyboardCommandValidator() 
        {
            RuleFor(x => x.Id).NotEmpty();
        }
    }
}
