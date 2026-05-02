using Journi.CodingChallenge.Core.Exceptions;
using Journi.CodingChallenge.Core.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Journi.CodingChallenge.Core.UseCases.Headphone.CreateHeadphone
{
    public class CreateHeadphoneCommandHandler : IRequestHandler<CreateHeadphoneCommand>
    {
        private readonly ICreateHeadphoneRepository createHeadphoneRepository;

        public CreateHeadphoneCommandHandler(ICreateHeadphoneRepository createHeadphoneRepository)
        {
            this.createHeadphoneRepository = createHeadphoneRepository;
        }

        public async Task Handle(CreateHeadphoneCommand request, CancellationToken cancellationToken)
        {
            var errors = new Dictionary<string, string[]>();
            var headphoneExists = await createHeadphoneRepository.CheckHeadphoneExistsAsync(request.Name);
            if (headphoneExists) 
            {
                errors.Add("headphoneName", new string[] { $"{request.Name} Already Exists." });
                throw new ValidationException(errors);
            }

            var headphone = new Models.Entities.Headphone()
            {
                Id = Guid.NewGuid(),
                BatteryLife = request.BatteryLife,
                Color = request.Color,
                Description = request.Description,
                ImageFileName = request.ImageFileName,
                Manufacturer = request.Manufacturer,
                Mic = request.Mic,
                Name = request.Name,
                NoiseCancellationType = request.NoiseCancellationType,
                Price = request.Price,
                ReleaseDate = request.ReleaseDate,
                Type = request.Type,
                Weight = request.Weight,
                Wireless = request.Wireless
            };
            await createHeadphoneRepository.AddHeadphoneAsync(headphone);
        }
    }
}
