using System;

namespace Journi.CodingChallenge.Api.Models.Headphone
{
    public class CreateHeadphoneRequest
    {
        public string BatteryLife { get; set; }
        public string Color { get; set; }
        public string Description { get; set; }
        public string ImageFileName { get; set; }
        public string Manufacturer { get; set; }
        public bool Mic { get; set; }
        public string Name { get; set; }
        public string NoiseCancellationType { get; set; }
        public decimal Price { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Type { get; set; }
        public string Weight { get; set; }
        public bool Wireless { get; set; }
    }
}
