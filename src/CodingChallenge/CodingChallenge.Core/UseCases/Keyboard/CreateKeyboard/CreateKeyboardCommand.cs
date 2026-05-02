using MediatR;
using System;

namespace Journi.CodingChallenge.Core.UseCases.Keyboard.CreateKeyboard
{
    public class CreateKeyboardCommand : IRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageFileName { get; set; }
        public bool Wireless { get; set; }
        public string Weight { get; set; }
        public DateTime ReleaseDate { get; set; }
        public bool IsMechanical { get; set; }

        public CreateKeyboardCommand(string name, string description, decimal price, string imageFileName, bool wireless, string weight, DateTime releaseDate, bool isMechanical)
        {
            Name = name;
            Description = description;
            Price = price;
            ImageFileName = imageFileName;
            Wireless = wireless;
            Weight = weight;
            ReleaseDate = releaseDate;
            IsMechanical = isMechanical;
        }
    }
}
