using Journi.CodingChallenge.Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Journi.CodingChallenge.Infrastructure.Repository.Headphone
{
    public class CreateHeadphoneRepository : ICreateHeadphoneRepository
    {
        private readonly CodingChallengeDbContext context;

        public CreateHeadphoneRepository(CodingChallengeDbContext context)
        {
            this.context = context;
        }

        public async Task<bool> CheckHeadphoneExistsAsync(string headphoneName)
        {
            return await context.Headphones.AnyAsync(x => x.Name == headphoneName);
        }

        public async Task AddHeadphoneAsync(Core.Models.Entities.Headphone headphone)
        {
            await context.Headphones.AddAsync(headphone);
            await context.SaveChangesAsync();
        }
    }
}
