using Journi.CodingChallenge.Core.Interfaces;
using System;
using System.Threading.Tasks;

namespace Journi.CodingChallenge.Infrastructure.Repository.Headphone
{
    public class UpdateHeadphoneRepository : IUpdateHeadphoneRepository
    {
        private readonly CodingChallengeDbContext context;

        public UpdateHeadphoneRepository(CodingChallengeDbContext context) 
        {
            this.context = context;
        }

        public async Task<Core.Models.Entities.Headphone> GetHeadphoneByIdAsync(Guid id)
        {
            var result = await context.Headphones.FindAsync(id);
            return result;
        }

        public async Task UpdateHeadphoneDetailsAsync(Core.Models.Entities.Headphone headphone)
        {
            context.Headphones.Update(headphone);
            await context.SaveChangesAsync();
        }
    }
}
