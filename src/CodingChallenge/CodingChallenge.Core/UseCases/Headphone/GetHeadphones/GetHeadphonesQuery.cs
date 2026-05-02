using Journi.CodingChallenge.Core.Models.DTOs;
using MediatR;

namespace Journi.CodingChallenge.Core.UseCases.Headphone.GetHeadphones
{
    public class GetHeadphonesQuery : IRequest<PagedResult<Models.Entities.Headphone>>
    {
        public int PageSize { get; set; }
        public int Page { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public string Color { get; set; }
        public bool? Wireless { get; set; }
        public bool? Mic { get; set; }

        public GetHeadphonesQuery(int pageSize, int page, string name, string manufacturer, string color, bool? wireless, bool? mic)
        {
            PageSize = pageSize;
            Page = page;
            Name = name;
            Manufacturer = manufacturer;
            Color = color;
            Wireless = wireless;
            Mic = mic;
        }
    }
}
