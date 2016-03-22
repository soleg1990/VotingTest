using System.Data.Entity;
using VotingTest.DAL.Entities;
using VotingTest.DAL.Interfaces;

namespace VotingTest.DAL.EntityFramework
{
    public class EFdbContext : DbContext
    {
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Voting> Votings { get; set; }
        public DbSet<VotingItem> Items { get; set; }
        public DbSet<Variant> Variants { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public EFdbContext() { }
        public EFdbContext(string connectionString)
            : base(connectionString)
        {
        }
    }
}
