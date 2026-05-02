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

        public async Task<PagedResult<Core.Models.Entities.Keyboard>> GetKeyboardsAsync(int pageSize, int page, string name, bool? wireless, bool? isMechanical)
        {
            if (page <= 0 || pageSize <= 0)
            {
                return new PagedResult<Core.Models.Entities.Keyboard>(new List<Core.Models.Entities.Keyboard>(), 0);
            }

            var query = context.Keyboards
                .AsNoTracking()
                .Where(x => (string.IsNullOrEmpty(name) || x.Name.Contains(name))
                && (!wireless.HasValue || x.Wireless == wireless.Value)
                && (!isMechanical.HasValue || x.IsMechanical == isMechanical.Value));

            var result = await query
                .OrderBy(x => x.Name)
                .Skip(pageSize * (page - 1))
                .Take(pageSize)
                .ToListAsync();

            var count = result.Count;

            return new PagedResult<Core.Models.Entities.Keyboard>(result, count);
        }
    }
}
