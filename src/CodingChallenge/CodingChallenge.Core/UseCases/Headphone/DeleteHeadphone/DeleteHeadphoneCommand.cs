using MediatR;
using System;

namespace Journi.CodingChallenge.Core.UseCases.Headphone.DeleteHeadphone
{
    public class DeleteHeadphoneCommand : IRequest
    {
        public Guid Id { get; set; }

        public DeleteHeadphoneCommand(Guid id)
        {
            Id = id;
        }
    }
}
