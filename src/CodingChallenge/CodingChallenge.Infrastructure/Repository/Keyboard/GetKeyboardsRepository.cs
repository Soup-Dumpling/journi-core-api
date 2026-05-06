using Journi.CodingChallenge.Core.Interfaces;
using Journi.CodingChallenge.Core.Models.DTOs;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Journi.CodingChallenge.Infrastructure.Repository.Keyboard
{
    public class GetKeyboardsRepository : IGetKeyboardsRepository
    {
        private readonly CodingChallengeDbContext context;

        public GetKeyboardsRepository(CodingChallengeDbContext context) 
        {
            this.context = context;
        }

        public async Task<PagedResult<GetKeyboardsQueryDTO>> GetKeyboardsAsync(int pageSize, int page, string name, bool? wireless, bool? isMechanical)
        {
            if (page <= 0 || pageSize <= 0)
            {
                return new PagedResult<GetKeyboardsQueryDTO>(new List<GetKeyboardsQueryDTO>(), 0);
            }

            var query = context.Keyboards
                .AsNoTracking()
                .Where(x => (string.IsNullOrEmpty(name) || x.Name.Contains(name))
                && (!wireless.HasValue || x.Wireless == wireless.Value)
                && (!isMechanical.HasValue || x.IsMechanical == isMechanical.Value)
                ).Select(x => new GetKeyboardsQueryDTO()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Price = x.Price,
                    ImageFileName = x.ImageFileName,
                    Wireless = x.Wireless,
                    IsMechanical = x.IsMechanical,
                });

            var result = await query
                .OrderBy(x => x.Name)
                .Skip(pageSize * (page - 1))
                .Take(pageSize)
                .ToListAsync();

            var count = result.Count;

            return new PagedResult<GetKeyboardsQueryDTO>(result, count);
        }
    }
}
