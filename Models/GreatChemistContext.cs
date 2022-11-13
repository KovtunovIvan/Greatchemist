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
        public DbSet<QuestionType2> QuestionsType2 { get; set; }
        public DbSet<QuestionType3> QuestionsType3 { get; set; }
        public DbSet<QuestionType4> QuestionsType4 { get; set; }
        public DbSet<QuestionType5> QuestionsType5 { get; set; }
        public DbSet<UserAnswerType1> UserAnswersType1 { get; set; }
        public DbSet<UserAnswerType2> UserAnswersType2 { get; set; }
        public DbSet<UserAnswerType3> UserAnswersType3 { get; set; }
        public DbSet<UserAnswerType4> UserAnswersType4 { get; set; }
        public DbSet<TaskTime> TaskTimes { get; set; }
        

        public DbSet<UserAnswersType1withRights> UserAnswersType1withRights { get; set; }
        public DbSet<UserAnswersType2withRights> UserAnswersType2withRights { get; set; }
        public DbSet<UserAnswersType3withRights> UserAnswersType3withRights { get; set; }
        public DbSet<UserAnswersType4withRights> UserAnswersType4withRights { get; set; }
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
            modelBuilder
                .Entity<UserAnswersType2withRights>()
                .ToView(nameof(UserAnswersType2withRights))
                .HasKey(u => new { u.Id });
            modelBuilder
                .Entity<UserAnswersType3withRights>()
                .ToView(nameof(UserAnswersType3withRights))
                .HasKey(u => new { u.Id });
            modelBuilder
                .Entity<UserAnswersType4withRights>()
                .ToView(nameof(UserAnswersType4withRights))
                .HasKey(u => new { u.Id });
        }
    }
}
