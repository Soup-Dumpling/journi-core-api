using Journi.CodingChallenge.Core.Models.Entities;
using Journi.CodingChallenge.Infrastructure.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Journi.CodingChallenge.Infrastructure
{
    public class CodingChallengeDbContext : DbContext
    {
        public CodingChallengeDbContext(DbContextOptions<CodingChallengeDbContext> contextOptions) : base(contextOptions) { }
        public DbSet<Headphone> Headphones { get; set; }
        public DbSet<Keyboard> Keyboards { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new HeadphoneMapping());
            modelBuilder.ApplyConfiguration(new KeyboardMapping());
        }
    }
}
