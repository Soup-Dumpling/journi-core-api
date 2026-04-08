//using Journi.CodingChallenge.Core.Models.Entities;
//using Journi.CodingChallenge.Infrastructure.Mappings;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journi.CodingChallenge.Infrastructure
{
    public class CodingChallengeDbContext : DbContext
    {
        public CodingChallengeDbContext(DbContextOptions<CodingChallengeDbContext> contextOptions) : base(contextOptions) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
