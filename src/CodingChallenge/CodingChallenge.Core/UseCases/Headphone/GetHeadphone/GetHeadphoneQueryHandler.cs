using Journi.CodingChallenge.Core.Exceptions;
using Journi.CodingChallenge.Core.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Journi.CodingChallenge.Core.UseCases.Headphone.GetHeadphone
{
    public class GetHeadphoneQueryHandler : IRequestHandler<GetHeadphoneQuery, Models.Entities.Headphone>
    {
        private readonly IGetHeadphoneRepository getHeadphoneRepository;

        public GetHeadphoneQueryHandler(IGetHeadphoneRepository getHeadphoneRepository)
        {
            this.getHeadphoneRepository = getHeadphoneRepository;
        }

        public async Task<Models.Entities.Headphone> Handle(GetHeadphoneQuery request, CancellationToken cancellationToken)
        {
            var result = await getHeadphoneRepository.GetHeadphoneByIdAsync(request.Id) ?? throw new NotFoundException();
            return result;
        }
    }
}
