using Journi.CodingChallenge.Core.Exceptions;
using Journi.CodingChallenge.Core.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Journi.CodingChallenge.Core.UseCases.Keyboard.CreateKeyboard
{
    public class CreateKeyboardCommandHandler : IRequestHandler<CreateKeyboardCommand>
    {
        private readonly ICreateKeyboardRepository createKeyboardRepository;

        public CreateKeyboardCommandHandler(ICreateKeyboardRepository createKeyboardRepository) 
        {
            this.createKeyboardRepository = createKeyboardRepository;
        }

        public async Task Handle(CreateKeyboardCommand request, CancellationToken cancellationToken)
        {
            var errors = new Dictionary<string, string[]>();
            var keyboardExists = await createKeyboardRepository.CheckKeyboardExistsAsync(request.Name);
            if (keyboardExists) 
            {
                errors.Add("keyboardName", new string[] { $"{request.Name} Already Exists." });
                throw new ValidationException(errors);
            }

            var keyboard = new Models.Entities.Keyboard()
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Description = request.Description,
                Price = request.Price,
                ImageFileName = request.ImageFileName,
                Wireless = request.Wireless,
                Weight = request.Weight,
                ReleaseDate = request.ReleaseDate,
                IsMechanical = request.IsMechanical,
            };
            await createKeyboardRepository.AddKeyboardAsync(keyboard);
        }
    }
}
