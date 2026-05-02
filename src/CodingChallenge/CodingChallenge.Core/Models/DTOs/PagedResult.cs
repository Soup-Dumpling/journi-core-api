using System.Collections.Generic;

namespace Journi.CodingChallenge.Core.Models.DTOs
{
    public class PagedResult<T> where T : class
    {
        public IEnumerable<T> Result { get; set; }
        public int Count { get; set; }

        public PagedResult(IEnumerable<T> items, int count)
        {
            Result = items;
            Count = count;
        }
    }
}
