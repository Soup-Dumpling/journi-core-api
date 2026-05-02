using Journi.CodingChallenge.Core.Interfaces;
using Journi.CodingChallenge.Core.Models.DTOs;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Journi.CodingChallenge.Core.UseCases.Headphone.GetHeadphones
{
    public class GetHeadphonesQueryHandler : IRequestHandler<GetHeadphonesQuery, PagedResult<Models.Entities.Headphone>>
    {
        private readonly IGetHeadphonesRepository getHeadphonesRepository;

        public GetHeadphonesQueryHandler(IGetHeadphonesRepository getHeadphonesRepository)
        {
            this.getHeadphonesRepository = getHeadphonesRepository;
        }

        public async Task<PagedResult<Models.Entities.Headphone>> Handle(GetHeadphonesQuery query, CancellationToken cancellationToken)
        {
            var result = await getHeadphonesRepository.GetHeadphonesAsync(query.PageSize, query.Page, query.Name, query.Manufacturer, query.Color, query.Wireless, query.Mic);
            return result;
        }
    }
}
