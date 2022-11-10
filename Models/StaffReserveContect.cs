using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tmp.Models
{
    public class StaffReserveContect : DbContext
    {
        public StaffReserveContect(DbContextOptions<StaffReserveContect> options)
            : base(options)
        {
           // Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=gdu-sqlls-001;Database=StaffReserve;Trusted_Connection=True;MultipleActiveResultSets=True");
        }
    }
}
