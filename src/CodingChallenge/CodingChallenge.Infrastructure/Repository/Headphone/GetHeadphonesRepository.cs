using Journi.CodingChallenge.Core.Interfaces;
using Journi.CodingChallenge.Core.Models.DTOs;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Journi.CodingChallenge.Infrastructure.Repository.Headphone
{
    public class GetHeadphonesRepository : IGetHeadphonesRepository
    {
        private readonly CodingChallengeDbContext context;

        public GetHeadphonesRepository(CodingChallengeDbContext context)
        {
            this.context = context;
        }

        public async Task<PagedResult<GetHeadphonesQueryDTO>> GetHeadphonesAsync(int pageSize, int page, string name, string manufacturer, string color, bool? wireless, bool? mic)
        {
            if (page <= 0 || pageSize <= 0)
            {
                return new PagedResult<GetHeadphonesQueryDTO>(new List<GetHeadphonesQueryDTO>(), 0);
            }

            var query = context.Headphones
                .AsNoTracking()
                .Where(x => (string.IsNullOrEmpty(name) || x.Name.Contains(name))
                && (string.IsNullOrEmpty(manufacturer) || x.Manufacturer.Contains(manufacturer))
                && (string.IsNullOrEmpty(color) || x.Color.Contains(color))
                && (!wireless.HasValue || x.Wireless == wireless.Value)
                && (!mic.HasValue || x.Mic == mic.Value)
                ).Select(x => new GetHeadphonesQueryDTO()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Manufacturer = x.Manufacturer,
                    Price = x.Price,
                    ImageFileName = x.ImageFileName,
                    Color = x.Color,
                    Type = x.Type,
                    BatteryLife = x.BatteryLife,
                    Wireless = x.Wireless,
                    Mic = x.Mic,
                });

            var result = await query
                .OrderBy(x => x.Name)
                .Skip(pageSize * (page - 1))
                .Take(pageSize)
                .ToListAsync();

            var count = result.Count;

            return new PagedResult<GetHeadphonesQueryDTO>(result, count);
        }
    }
}
