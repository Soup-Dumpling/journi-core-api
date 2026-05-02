using Journi.CodingChallenge.Core.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Journi.CodingChallenge.Infrastructure.Mappings
{
    public class KeyboardMapping : IEntityTypeConfiguration<Keyboard>
    {
        public void Configure(EntityTypeBuilder<Keyboard> builder) 
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.Name).IsUnique();
            builder.Property(x => x.Price).HasPrecision(18, 2);
            builder.HasData(
                new Keyboard() { Id = Guid.Parse("3d123b03-4ba3-4538-a8b9-3b5ca640d134"), Name = "Logitech MX Keys S Keyboard", Description = "A high-performance keyboard, engineered for comfortable, fast, fluid typing, with smart illumination, and programmable keys.", Price = 109.99m, ImageFileName = "logi-mx-keys-s-intro.webp", Wireless = true, Weight = "810 grams", ReleaseDate = new DateTime(2023, 6, 6, 9, 0, 0, DateTimeKind.Utc), IsMechanical = false },
                new Keyboard() { Id = Guid.Parse("b2bbd6c9-b3e0-4a36-b73e-c85a7d120b5c"), Name = "Steelseries Apex Pro TKL Gen 3 Gaming Keyboard", Description = "Push the boundaries with cutting-edge, industry-leading OmniPoint 3.0 switches, now with brand new features that change the way you game: Rapid Trigger, Protection Mode, Rapid Tap and GG QuickSet.", Price = 184.99m, ImageFileName = "apex_pro_tkl_black_img_buy_01.png", Wireless = false, Weight = "1403 grams", ReleaseDate = new DateTime(2025, 3, 25, 9, 0, 0, DateTimeKind.Utc), IsMechanical = true });
        }
    }
}
