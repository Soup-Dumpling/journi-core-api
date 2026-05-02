using Journi.CodingChallenge.Core.Models.Entities;
using System;
using System.Threading.Tasks;

namespace Journi.CodingChallenge.Core.Interfaces
{
    public interface IUpdateKeyboardRepository
    {
        Task<Keyboard> GetKeyboardByIdAsync(Guid id);
        Task UpdateKeyboardDetailsAsync(Keyboard keyboard);
    }
}
