using Journi.CodingChallenge.Core.Models.DTOs;
using Journi.CodingChallenge.Core.Models.Entities;
using System.Threading.Tasks;

namespace Journi.CodingChallenge.Core.Interfaces
{
    public interface IGetHeadphonesRepository
    {
        Task<PagedResult<GetHeadphonesQueryDTO>> GetHeadphonesAsync(int pageSize, int page, string name, string manufacturer, string color, bool? wireless, bool? mic);
    }
}
