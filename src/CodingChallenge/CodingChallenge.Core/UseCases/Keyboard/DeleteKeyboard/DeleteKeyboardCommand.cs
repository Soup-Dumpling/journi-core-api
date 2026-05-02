using MediatR;
using System;

namespace Journi.CodingChallenge.Core.UseCases.Keyboard.DeleteKeyboard
{
    public class DeleteKeyboardCommand : IRequest
    {
        public Guid Id { get; set; }

        public DeleteKeyboardCommand(Guid id)
        {
            Id = id;
        }
    }
}
