using FluentValidation;

namespace Journi.CodingChallenge.Core.UseCases.Keyboard.UpdateKeyboard
{
    public class UpdateKeyboardCommandValidator : AbstractValidator<UpdateKeyboardCommand>
    {
        public UpdateKeyboardCommandValidator() 
        {
            RuleFor(x => x.Id).NotEmpty();
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.Description).NotEmpty();
            RuleFor(x => x.Price).NotEmpty();
            RuleFor(x => x.ImageFileName).NotEmpty();
            RuleFor(x => x.Wireless).NotNull();
            RuleFor(x => x.Weight).NotEmpty();
            RuleFor(x => x.ReleaseDate).NotEmpty();
            RuleFor(x => x.IsMechanical).NotNull();
        }
    }
}
