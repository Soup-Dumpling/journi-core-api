using FluentValidation;

namespace Journi.CodingChallenge.Core.UseCases.Headphone.DeleteHeadphone
{
    public class DeleteHeadphoneCommandValidator : AbstractValidator<DeleteHeadphoneCommand>
    {
        public DeleteHeadphoneCommandValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
        }
    }
}
