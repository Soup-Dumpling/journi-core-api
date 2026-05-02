using Journi.CodingChallenge.Core.Models.DTOs;
using MediatR;

namespace Journi.CodingChallenge.Core.UseCases.Keyboard.GetKeyboards
{
    public class GetKeyboardsQuery : IRequest<PagedResult<Models.Entities.Keyboard>>
    {
        public int PageSize { get; set; }
        public int Page { get; set; }
        public string Name { get; set; }
        public bool? Wireless { get; set; }
        public bool? IsMechanical { get; set; }

        public GetKeyboardsQuery(int pageSize, int page, string name, bool? wireless, bool? isMechanical)
        {
            PageSize = pageSize;
            Page = page;
            Name = name;
            Wireless = wireless;
            IsMechanical = isMechanical;
        }
    }
}
