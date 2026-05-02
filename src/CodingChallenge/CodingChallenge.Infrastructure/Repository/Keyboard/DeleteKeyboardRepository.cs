using Journi.CodingChallenge.Core.Interfaces;
using System;
using System.Threading.Tasks;

namespace Journi.CodingChallenge.Infrastructure.Repository.Keyboard
{
    public class DeleteKeyboardRepository : IDeleteKeyboardRepository
    {
        private readonly CodingChallengeDbContext context;

        public DeleteKeyboardRepository(CodingChallengeDbContext context)
        {
            this.context = context;
        }

        public async Task<Core.Models.Entities.Keyboard> GetKeyboardByIdAsync(Guid id)
        {
            var result = await context.Keyboards.FindAsync(id);
            return result;
        }

        public async Task DeleteKeyboardAsync(Core.Models.Entities.Keyboard keyboard)
        {
            context.Keyboards.Remove(keyboard);
            await context.SaveChangesAsync();
        }
    }
}
