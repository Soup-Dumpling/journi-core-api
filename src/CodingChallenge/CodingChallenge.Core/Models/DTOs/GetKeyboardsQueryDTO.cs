using System;

namespace Journi.CodingChallenge.Core.Models.DTOs
{
    public class GetKeyboardsQueryDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ImageFileName { get; set; }
        public bool Wireless { get; set; }
        public bool IsMechanical { get; set; }
    }
}
