using Journi.CodingChallenge.Core.Exceptions;
using Journi.CodingChallenge.Core.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Journi.CodingChallenge.Core.UseCases.Keyboard.DeleteKeyboard
{
    public class DeleteKeyboardCommandHandler : IRequestHandler<DeleteKeyboardCommand>
    {
        private readonly IDeleteKeyboardRepository deleteKeyboardRepository;

        public DeleteKeyboardCommandHandler(IDeleteKeyboardRepository deleteKeyboardRepository) 
        {
            this.deleteKeyboardRepository = deleteKeyboardRepository;
        }

        public async Task Handle(DeleteKeyboardCommand request, CancellationToken cancellationToken)
        {
            var keyboard = await deleteKeyboardRepository.GetKeyboardByIdAsync(request.Id) ?? throw new NotFoundException();
            await deleteKeyboardRepository.DeleteKeyboardAsync(keyboard);
        }
    }
}
