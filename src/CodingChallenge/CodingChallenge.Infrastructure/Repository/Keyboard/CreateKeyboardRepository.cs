using Journi.CodingChallenge.Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Journi.CodingChallenge.Infrastructure.Repository.Keyboard
{
    public class CreateKeyboardRepository : ICreateKeyboardRepository
    {
        private readonly CodingChallengeDbContext context;

        public CreateKeyboardRepository(CodingChallengeDbContext context)
        {
            this.context = context;
        }

        public async Task<bool> CheckKeyboardExistsAsync(string keyboardName)
        {
            return await context.Keyboards.AnyAsync(x => x.Name == keyboardName);
        }

        public async Task AddKeyboardAsync(Core.Models.Entities.Keyboard keyboard)
        {
            await context.Keyboards.AddAsync(keyboard);
            await context.SaveChangesAsync();
        }
    }
}
