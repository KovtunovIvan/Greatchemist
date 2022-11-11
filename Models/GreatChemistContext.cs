using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tmp.Models
{
    public class GreatChemistContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<MainHand> MainHands { get; set; }

        public GreatChemistContext(DbContextOptions<GreatChemistContext> options)
            : base(options)
        {
           // Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {}
    }
}
