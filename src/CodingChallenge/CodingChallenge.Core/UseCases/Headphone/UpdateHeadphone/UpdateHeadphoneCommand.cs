using MediatR;
using System;

namespace Journi.CodingChallenge.Core.UseCases.Headphone.UpdateHeadphone
{
    public class UpdateHeadphoneCommand : IRequest
    {
        public Guid Id { get; set; }
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

        public UpdateHeadphoneCommand(Guid id, string batteryLife, string color, string description, string imageFileName, string manufacturer, bool mic, string name, string noiseCancellationType, decimal price, DateTime releaseDate, string type, string weight, bool wireless)
        {
            Id = id;
            BatteryLife = batteryLife;
            Color = color;
            Description = description;
            ImageFileName = imageFileName;
            Manufacturer = manufacturer;
            Mic = mic;
            Name = name;
            NoiseCancellationType = noiseCancellationType;
            Price = price;
            ReleaseDate = releaseDate;
            Type = type;
            Weight = weight;
            Wireless = wireless;
        }
    }
}
