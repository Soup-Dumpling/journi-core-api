using Journi.CodingChallenge.Core.Models.Entities;
using System.Threading.Tasks;

namespace Journi.CodingChallenge.Core.Interfaces
{
    public interface ICreateKeyboardRepository
    {
        Task<bool> CheckKeyboardExistsAsync(string keyboardName);
        Task AddKeyboardAsync(Keyboard keyboard);
    }
}
