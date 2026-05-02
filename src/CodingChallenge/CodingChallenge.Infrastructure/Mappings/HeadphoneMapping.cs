using Journi.CodingChallenge.Core.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Journi.CodingChallenge.Infrastructure.Mappings
{
    public class HeadphoneMapping : IEntityTypeConfiguration<Headphone>
    {
        public void Configure(EntityTypeBuilder<Headphone> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.Name).IsUnique();
            builder.Property(x => x.Price).HasPrecision(18, 2);
            builder.HasData(
                new Headphone() { Id = Guid.Parse("51f2e82c-69af-48b4-8d10-98bc5253ef3b"), BatteryLife = "N/A", Color = "Black", Description = "Highly regarded closed-back studio headphones known for their detailed sound reproduction and comfortable fit.", ImageFileName = "Beyerdynamic_DT_770_Pro.webp", Manufacturer = "Beyerdynamic", Mic = false, Name = "Beyerdynamic DT 770 Pro", NoiseCancellationType = "None", Price = 179m, ReleaseDate = new DateTime(2024, 4, 19, 9, 0, 0, DateTimeKind.Utc), Type = "Over-Ear", Weight = "270 grams", Wireless = false },
                new Headphone() { Id = Guid.Parse("55c6b66e-2550-4490-bbfb-2bb2d26cfa99"), BatteryLife = "Up to 20 hours", Color = "Silver", Description = "Sleek design, exceptional noise cancellation, and impressive sound quality make these headphones a favorite among travelers and music enthusiasts.", ImageFileName = "Bose_Noise_Cancelling_Headphones_700.jpg", Manufacturer = "Bose", Mic = true, Name = "Bose Noise Cancelling Headphones 700", NoiseCancellationType = "Adaptive Noise Cancellation", Price = 379.95m, ReleaseDate = new DateTime(2019, 6, 30, 9, 0, 0, DateTimeKind.Utc), Type = "Over-Ear", Weight = "250 grams", Wireless = true },
                new Headphone() { Id = Guid.Parse("73912724-86c8-440a-b668-de62757a649e"), BatteryLife = "N/A", Color = "Black", Description = "Professional closed-back studio headphones with accurate sound reproduction, foldable design, and ergonomic fit.", ImageFileName = "AKG_K371.webp", Manufacturer = "AKG", Mic = false, Name = "AKG K371", NoiseCancellationType = "None", Price = 149m, ReleaseDate = new DateTime(2019, 8, 26, 9, 0, 0, DateTimeKind.Utc), Type = "Over-Ear", Weight = "255 grams", Wireless = false },
                new Headphone() { Id = Guid.Parse("80281daf-321d-4d5e-90d4-7c86a41658c1"), BatteryLife = "Up to 30 hours", Color = "Beige", Description = "Industry-leading noise cancellation, comfortable ear pads, and long battery life make these headphones a top choice for audiophiles.", ImageFileName = "Sony_WH-1000XM4.webp", Manufacturer = "Sony", Mic = true, Name = "Sony WH-1000XM4", NoiseCancellationType = "Active Noise Cancellation", Price = 349.99m, ReleaseDate = new DateTime(2020, 8, 18, 9, 0, 0, DateTimeKind.Utc), Type = "Over-Ear", Weight = "254 grams", Wireless = true },
                new Headphone() { Id = Guid.Parse("82ff5cf5-5fc7-4e10-9837-29f3298c5818"), BatteryLife = "Up to 36 hours", Color = "Black", Description = "Comfortable over-ear headphones with excellent noise cancellation, long battery life, and customizable sound profiles.", ImageFileName = "Jabra_Elite_85h.jpg", Manufacturer = "Jabra", Mic = true, Name = "Jabra Elite 85h", NoiseCancellationType = "Hybrid Active Noise Cancellation", Price = 249.99m, ReleaseDate = new DateTime(2019, 4, 15, 9, 0, 0, DateTimeKind.Utc), Type = "Over-Ear", Weight = "296 grams", Wireless = true },
                new Headphone() { Id = Guid.Parse("aa328d09-ba2c-4bfd-9620-ae973dac2007"), BatteryLife = "N/A", Color = "Blue", Description = "Professional-grade studio monitor headphones with exceptional clarity, sound isolation, and durability.", ImageFileName = "Audio-Technica_ATH-M50x.webp", Manufacturer = "Audio-Technica", Mic = false, Name = "Audio-Technica ATH-M50x", NoiseCancellationType = "None", Price = 149m, ReleaseDate = new DateTime(2014, 1, 23, 9, 0, 0, DateTimeKind.Utc), Type = "Over-Ear", Weight = "285 grams", Wireless = false },
                new Headphone() { Id = Guid.Parse("b9e754f2-1d55-42e5-bf9d-83b2b4ac7cb3"), BatteryLife = "Up to 22 hours", Color = "Red", Description = "Stylish on-ear headphones with active noise cancellation, impressive sound quality, and up to 22 hours of battery life.", ImageFileName = "Beats_Solo_Pro.jpeg", Manufacturer = "Beats", Mic = true, Name = "Beats Solo Pro", NoiseCancellationType = "Active Noise Cancellation", Price = 299.95m, ReleaseDate = new DateTime(2019, 10, 30, 9, 0, 0, DateTimeKind.Utc), Type = "On-Ear", Weight = "267 grams", Wireless = true },
                new Headphone() { Id = Guid.Parse("e088cba7-f5f5-4da8-873c-56c6a79f5190"), BatteryLife = "N/A", Color = "Black", Description = "Premium open-back headphones known for their outstanding sound quality, luxurious comfort, and high-quality materials.", ImageFileName = "Sennheiser_HD_800_S.jpg", Manufacturer = "Sennheiser", Mic = false, Name = "Sennheiser HD 800 S", NoiseCancellationType = "Passive Noise Cancellation", Price = 1499.95m, ReleaseDate = new DateTime(2015, 12, 14, 9, 0, 0, DateTimeKind.Utc), Type = "Over-Ear", Weight = "330 grams", Wireless = false });
        }
    }
}
