using System;

namespace Journi.CodingChallenge.Core.Models.Entities
{
    public abstract class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageFileName { get; set; }
        public bool Wireless { get; set; }
        public string Weight { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
