using Journi.CodingChallenge.Core.Models.Entities;
using System.Threading.Tasks;

namespace Journi.CodingChallenge.Core.Interfaces
{
    public interface ICreateHeadphoneRepository
    {
        Task<bool> CheckHeadphoneExistsAsync(string headphoneName);
        Task AddHeadphoneAsync(Headphone headphone);
    }
}
