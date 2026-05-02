using Journi.CodingChallenge.Core.Exceptions;
using Journi.CodingChallenge.Core.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Journi.CodingChallenge.Core.UseCases.Headphone.UpdateHeadphone
{
    public class UpdateHeadphoneCommandHandler : IRequestHandler<UpdateHeadphoneCommand>
    {
        private readonly IUpdateHeadphoneRepository updateHeadphoneRepository;

        public UpdateHeadphoneCommandHandler(IUpdateHeadphoneRepository updateHeadphoneRepository)
        {
            this.updateHeadphoneRepository = updateHeadphoneRepository;
        }

        public async Task Handle(UpdateHeadphoneCommand request, CancellationToken cancellationToken)
        {
            var headphone = await updateHeadphoneRepository.GetHeadphoneByIdAsync(request.Id) ?? throw new NotFoundException();

            headphone.BatteryLife = request.BatteryLife;
            headphone.Color = request.Color;
            headphone.Description = request.Description;
            headphone.ImageFileName = request.ImageFileName;
            headphone.Manufacturer = request.Manufacturer;
            headphone.Mic = request.Mic;
            headphone.Name = request.Name;
            headphone.NoiseCancellationType = request.NoiseCancellationType;
            headphone.Price = request.Price;
            headphone.ReleaseDate = request.ReleaseDate;
            headphone.Type = request.Type;
            headphone.Weight = request.Weight;
            headphone.Wireless = request.Wireless;

            await updateHeadphoneRepository.UpdateHeadphoneDetailsAsync(headphone);
        }
    }
}
