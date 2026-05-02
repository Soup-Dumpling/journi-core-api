using Journi.CodingChallenge.Core.Interfaces;
using System;
using System.Threading.Tasks;

namespace Journi.CodingChallenge.Infrastructure.Repository.Headphone
{
    public class GetHeadphoneRepository : IGetHeadphoneRepository
    {
        private readonly CodingChallengeDbContext context;

        public GetHeadphoneRepository(CodingChallengeDbContext context)
        {
            this.context = context;
        }

        public async Task<Core.Models.Entities.Headphone> GetHeadphoneByIdAsync(Guid id)
        {
            var result = await context.Headphones.FindAsync(id);
            return result;
        }
    }
}
