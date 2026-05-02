using System;

namespace Journi.CodingChallenge.Api.Models.Keyboard
{
    public class CreateKeyboardRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageFileName { get; set; }
        public bool Wireless { get; set; }
        public string Weight { get; set; }
        public DateTime ReleaseDate { get; set; }
        public bool IsMechanical { get; set; }
    }
}
