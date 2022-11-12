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
        public DbSet<Iteration> Iterations { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<QuestionType1> QuestionsType1 { get; set; }
        public DbSet<UserAnswerType1> UserAnswersType1 { get; set; }
        public DbSet<TaskTime> TaskTimes { get; set; }
        

        public DbSet<UserAnswersType1withRights> UserAnswersType1withRights { get; set; }
        public GreatChemistContext(DbContextOptions<GreatChemistContext> options)
            : base(options)
        {
           // Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<UserAnswersType1withRights>()
                .ToView(nameof(UserAnswersType1withRights))
                .HasKey(u => new { u.Id });
        }
    }
}
