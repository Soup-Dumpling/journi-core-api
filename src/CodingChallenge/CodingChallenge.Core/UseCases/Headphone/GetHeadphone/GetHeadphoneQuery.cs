using MediatR;
using System;

namespace Journi.CodingChallenge.Core.UseCases.Headphone.GetHeadphone
{
    public class GetHeadphoneQuery : IRequest<Models.Entities.Headphone>
    {
        public Guid Id { get; set; }

        public GetHeadphoneQuery(Guid id)
        {
            Id = id;
        }
    }
}
