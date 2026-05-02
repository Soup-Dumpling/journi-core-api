using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Journi.CodingChallenge.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initialise : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Headphones",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BatteryLife = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoiseCancellationType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mic = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    ImageFileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Wireless = table.Column<bool>(type: "bit", nullable: false),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Headphones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Keyboards",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsMechanical = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    ImageFileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Wireless = table.Column<bool>(type: "bit", nullable: false),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Keyboards", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Headphones",
                columns: new[] { "Id", "BatteryLife", "Color", "Description", "ImageFileName", "Manufacturer", "Mic", "Name", "NoiseCancellationType", "Price", "ReleaseDate", "Type", "Weight", "Wireless" },
                values: new object[,]
                {
                    { new Guid("51f2e82c-69af-48b4-8d10-98bc5253ef3b"), "N/A", "Black", "Highly regarded closed-back studio headphones known for their detailed sound reproduction and comfortable fit.", "Beyerdynamic_DT_770_Pro.webp", "Beyerdynamic", false, "Beyerdynamic DT 770 Pro", "None", 179m, new DateTime(2024, 4, 19, 9, 0, 0, 0, DateTimeKind.Utc), "Over-Ear", "270 grams", false },
                    { new Guid("55c6b66e-2550-4490-bbfb-2bb2d26cfa99"), "Up to 20 hours", "Silver", "Sleek design, exceptional noise cancellation, and impressive sound quality make these headphones a favorite among travelers and music enthusiasts.", "Bose_Noise_Cancelling_Headphones_700.jpg", "Bose", true, "Bose Noise Cancelling Headphones 700", "Adaptive Noise Cancellation", 379.95m, new DateTime(2019, 6, 30, 9, 0, 0, 0, DateTimeKind.Utc), "Over-Ear", "250 grams", true },
                    { new Guid("73912724-86c8-440a-b668-de62757a649e"), "N/A", "Black", "Professional closed-back studio headphones with accurate sound reproduction, foldable design, and ergonomic fit.", "AKG_K371.webp", "AKG", false, "AKG K371", "None", 149m, new DateTime(2019, 8, 26, 9, 0, 0, 0, DateTimeKind.Utc), "Over-Ear", "255 grams", false },
                    { new Guid("80281daf-321d-4d5e-90d4-7c86a41658c1"), "Up to 30 hours", "Beige", "Industry-leading noise cancellation, comfortable ear pads, and long battery life make these headphones a top choice for audiophiles.", "Sony_WH-1000XM4.webp", "Sony", true, "Sony WH-1000XM4", "Active Noise Cancellation", 349.99m, new DateTime(2020, 8, 18, 9, 0, 0, 0, DateTimeKind.Utc), "Over-Ear", "254 grams", true },
                    { new Guid("82ff5cf5-5fc7-4e10-9837-29f3298c5818"), "Up to 36 hours", "Black", "Comfortable over-ear headphones with excellent noise cancellation, long battery life, and customizable sound profiles.", "Jabra_Elite_85h.jpg", "Jabra", true, "Jabra Elite 85h", "Hybrid Active Noise Cancellation", 249.99m, new DateTime(2019, 4, 15, 9, 0, 0, 0, DateTimeKind.Utc), "Over-Ear", "296 grams", true },
                    { new Guid("aa328d09-ba2c-4bfd-9620-ae973dac2007"), "N/A", "Blue", "Professional-grade studio monitor headphones with exceptional clarity, sound isolation, and durability.", "Audio-Technica_ATH-M50x.webp", "Audio-Technica", false, "Audio-Technica ATH-M50x", "None", 149m, new DateTime(2014, 1, 23, 9, 0, 0, 0, DateTimeKind.Utc), "Over-Ear", "285 grams", false },
                    { new Guid("b9e754f2-1d55-42e5-bf9d-83b2b4ac7cb3"), "Up to 22 hours", "Red", "Stylish on-ear headphones with active noise cancellation, impressive sound quality, and up to 22 hours of battery life.", "Beats_Solo_Pro.jpeg", "Beats", true, "Beats Solo Pro", "Active Noise Cancellation", 299.95m, new DateTime(2019, 10, 30, 9, 0, 0, 0, DateTimeKind.Utc), "On-Ear", "267 grams", true },
                    { new Guid("e088cba7-f5f5-4da8-873c-56c6a79f5190"), "N/A", "Black", "Premium open-back headphones known for their outstanding sound quality, luxurious comfort, and high-quality materials.", "Sennheiser_HD_800_S.jpg", "Sennheiser", false, "Sennheiser HD 800 S", "Passive Noise Cancellation", 1499.95m, new DateTime(2015, 12, 14, 9, 0, 0, 0, DateTimeKind.Utc), "Over-Ear", "330 grams", false }
                });

            migrationBuilder.InsertData(
                table: "Keyboards",
                columns: new[] { "Id", "Description", "ImageFileName", "IsMechanical", "Name", "Price", "ReleaseDate", "Weight", "Wireless" },
                values: new object[,]
                {
                    { new Guid("3d123b03-4ba3-4538-a8b9-3b5ca640d134"), "A high-performance keyboard, engineered for comfortable, fast, fluid typing, with smart illumination, and programmable keys.", "logi-mx-keys-s-intro.webp", false, "Logitech MX Keys S Keyboard", 109.99m, new DateTime(2023, 6, 6, 9, 0, 0, 0, DateTimeKind.Utc), "810 grams", true },
                    { new Guid("b2bbd6c9-b3e0-4a36-b73e-c85a7d120b5c"), "Push the boundaries with cutting-edge, industry-leading OmniPoint 3.0 switches, now with brand new features that change the way you game: Rapid Trigger, Protection Mode, Rapid Tap and GG QuickSet.", "apex_pro_tkl_black_img_buy_01.png", true, "Steelseries Apex Pro TKL Gen 3 Gaming Keyboard", 184.99m, new DateTime(2025, 3, 25, 9, 0, 0, 0, DateTimeKind.Utc), "1403 grams", false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Headphones_Name",
                table: "Headphones",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Keyboards_Name",
                table: "Keyboards",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Headphones");

            migrationBuilder.DropTable(
                name: "Keyboards");
        }
    }
}
