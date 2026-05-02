using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journi.CodingChallenge.Core.UseCases.Keyboard.UpdateKeyboard
{
    public class UpdateKeyboardCommand : IRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageFileName { get; set; }
        public bool Wireless { get; set; }
        public string Weight { get; set; }
        public DateTime ReleaseDate { get; set; }
        public bool IsMechanical { get; set; }

        public UpdateKeyboardCommand(Guid id, string name, string description, decimal price, string imageFileName, bool wireless, string weight, DateTime releaseDate, bool isMechanical)
        {
            Id = id;
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
