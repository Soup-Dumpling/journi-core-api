using MediatR;
using System;

namespace Journi.CodingChallenge.Core.UseCases.Keyboard.GetKeyboard
{
    public class GetKeyboardQuery : IRequest<Models.Entities.Keyboard>
    {
        public Guid Id { get; set; }

        public GetKeyboardQuery(Guid id)
        {
            Id = id;
        }
    }
}
