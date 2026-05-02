using Journi.CodingChallenge.Core.Exceptions;
using Journi.CodingChallenge.Core.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Journi.CodingChallenge.Core.UseCases.Headphone.DeleteHeadphone
{
    public class DeleteHeadphoneCommandHandler : IRequestHandler<DeleteHeadphoneCommand>
    {
        private readonly IDeleteHeadphoneRepository deleteHeadphoneRepository;

        public DeleteHeadphoneCommandHandler(IDeleteHeadphoneRepository deleteHeadphoneRepository)
        {
            this.deleteHeadphoneRepository = deleteHeadphoneRepository;
        }

        public async Task Handle(DeleteHeadphoneCommand request, CancellationToken cancellationToken)
        {
            var headphone = await deleteHeadphoneRepository.GetHeadphoneByIdAsync(request.Id) ?? throw new NotFoundException();
            await deleteHeadphoneRepository.DeleteHeadphoneAsync(headphone);
        }
    }
}
