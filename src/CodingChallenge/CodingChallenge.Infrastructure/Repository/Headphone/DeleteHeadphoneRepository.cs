using Journi.CodingChallenge.Core.Interfaces;
using System;
using System.Threading.Tasks;

namespace Journi.CodingChallenge.Infrastructure.Repository.Headphone
{
    public class DeleteHeadphoneRepository : IDeleteHeadphoneRepository
    {
        private readonly CodingChallengeDbContext context;

        public DeleteHeadphoneRepository(CodingChallengeDbContext context)
        {
            this.context = context;
        }

        public async Task<Core.Models.Entities.Headphone> GetHeadphoneByIdAsync(Guid id)
        {
            var result = await context.Headphones.FindAsync(id);
            return result;
        }

        public async Task DeleteHeadphoneAsync(Core.Models.Entities.Headphone headphone)
        {
            context.Headphones.Remove(headphone);
            await context.SaveChangesAsync();
        }
    }
}
