using Journi.CodingChallenge.Core.Exceptions;
using Journi.CodingChallenge.Core.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Journi.CodingChallenge.Core.UseCases.Keyboard.UpdateKeyboard
{
    public class UpdateKeyboardCommandHandler : IRequestHandler<UpdateKeyboardCommand>
    {
        private readonly IUpdateKeyboardRepository updateKeyboardRepository;

        public UpdateKeyboardCommandHandler(IUpdateKeyboardRepository updateKeyboardRepository) 
        {
            this.updateKeyboardRepository = updateKeyboardRepository;
        }

        public async Task Handle(UpdateKeyboardCommand request, CancellationToken cancellationToken)
        {
            var keyboard = await updateKeyboardRepository.GetKeyboardByIdAsync(request.Id) ?? throw new NotFoundException();

            keyboard.Name = request.Name;
            keyboard.Description = request.Description;
            keyboard.Price = request.Price;
            keyboard.ImageFileName = request.ImageFileName;
            keyboard.Wireless = request.Wireless;
            keyboard.Weight = request.Weight;
            keyboard.ReleaseDate = request.ReleaseDate;
            keyboard.IsMechanical = request.IsMechanical;

            await updateKeyboardRepository.UpdateKeyboardDetailsAsync(keyboard);
        }
    }
}
