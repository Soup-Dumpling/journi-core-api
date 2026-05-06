using Journi.CodingChallenge.Core.Models.DTOs;
using Journi.CodingChallenge.Core.Models.Entities;
using System.Threading.Tasks;

namespace Journi.CodingChallenge.Core.Interfaces
{
    public interface IGetKeyboardsRepository
    {
        Task<PagedResult<GetKeyboardsQueryDTO>> GetKeyboardsAsync(int pageSize, int page, string name, bool? wireless, bool? isMechanical);
    }
}
