using Journi.CodingChallenge.Core.Models.Entities;
using System;
using System.Threading.Tasks;

namespace Journi.CodingChallenge.Core.Interfaces
{
    public interface IGetHeadphoneRepository
    {
        Task<Headphone> GetHeadphoneByIdAsync(Guid id);
    }
}
