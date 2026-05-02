using Journi.CodingChallenge.Core.Interfaces;
using Journi.CodingChallenge.Core.Models.DTOs;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Journi.CodingChallenge.Core.UseCases.Keyboard.GetKeyboards
{
    public class GetKeyboardsQueryHandler : IRequestHandler<GetKeyboardsQuery, PagedResult<Models.Entities.Keyboard>>
    {
        private readonly IGetKeyboardsRepository getKeyboardsRepository;

        public GetKeyboardsQueryHandler(IGetKeyboardsRepository getKeyboardsRepository)
        {
            this.getKeyboardsRepository = getKeyboardsRepository;
        }

        public async Task<PagedResult<Models.Entities.Keyboard>> Handle(GetKeyboardsQuery request, CancellationToken cancellationToken)
        {
            var result = await getKeyboardsRepository.GetKeyboardsAsync(request.PageSize, request.Page, request.Name, request.Wireless, request.IsMechanical);
            return result;
        }
    }
}
