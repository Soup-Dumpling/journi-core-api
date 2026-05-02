using Journi.CodingChallenge.Core.Interfaces;
using System;
using System.Threading.Tasks;

namespace Journi.CodingChallenge.Infrastructure.Repository.Keyboard
{
    public class GetKeyboardRepository : IGetKeyboardRepository
    {
        private readonly CodingChallengeDbContext context;

        public GetKeyboardRepository(CodingChallengeDbContext context)
        {
            this.context = context;
        }

        public async Task<Core.Models.Entities.Keyboard> GetKeyboardByIdAsync(Guid id)
        {
            var result = await context.Keyboards.FindAsync(id);
            return result;
        }
    }
}
