using System;

namespace Journi.CodingChallenge.Core.Models.DTOs
{
    public class GetHeadphonesQueryDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public decimal Price { get; set; }
        public string ImageFileName { get; set; }
        public string Color { get; set; }
        public string Type { get; set; }
        public string BatteryLife { get; set; }
        public bool Wireless { get; set; }
        public bool Mic { get; set; }   
    }
}
