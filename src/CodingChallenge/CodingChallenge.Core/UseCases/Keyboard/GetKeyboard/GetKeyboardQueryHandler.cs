using Journi.CodingChallenge.Core.Exceptions;
using Journi.CodingChallenge.Core.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Journi.CodingChallenge.Core.UseCases.Keyboard.GetKeyboard
{
    public class GetKeyboardQueryHandler : IRequestHandler<GetKeyboardQuery, Models.Entities.Keyboard>
    {
        private readonly IGetKeyboardRepository getKeyboardRepository;

        public GetKeyboardQueryHandler(IGetKeyboardRepository getKeyboardRepository) 
        {
            this.getKeyboardRepository = getKeyboardRepository;
        }

        public async Task<Models.Entities.Keyboard> Handle(GetKeyboardQuery request, CancellationToken cancellationToken)
        {
            var result = await getKeyboardRepository.GetKeyboardByIdAsync(request.Id) ?? throw new NotFoundException();
            return result;
        }
    }
}
