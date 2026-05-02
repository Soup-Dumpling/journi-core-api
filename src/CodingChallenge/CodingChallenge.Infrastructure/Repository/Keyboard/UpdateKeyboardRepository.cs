using Journi.CodingChallenge.Core.Interfaces;
using System;
using System.Threading.Tasks;

namespace Journi.CodingChallenge.Infrastructure.Repository.Keyboard
{
    public class UpdateKeyboardRepository : IUpdateKeyboardRepository
    {
        private readonly CodingChallengeDbContext context;

        public UpdateKeyboardRepository(CodingChallengeDbContext context) 
        {
            this.context = context;
        }

        public async Task<Core.Models.Entities.Keyboard> GetKeyboardByIdAsync(Guid id)
        {
            var result = await context.Keyboards.FindAsync(id);
            return result;
        }

        public async Task UpdateKeyboardDetailsAsync(Core.Models.Entities.Keyboard keyboard)
        {
            context.Keyboards.Update(keyboard);
            await context.SaveChangesAsync();
        }
    }
}
