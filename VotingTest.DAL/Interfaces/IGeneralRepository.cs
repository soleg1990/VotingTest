using VotingTest.DAL.Entities;
using VotingTest.DAL.Interfaces;

namespace VotingTest.DAL.Repositories
{
    public interface IGeneralRepository
    {
        IBaseRepository<Role> Roles { get; }
        IBaseRepository<User> Users { get; }
        IBaseRepository<Voting> Votings { get; }
        IBaseRepository<VotingItem> Items { get; }
        IBaseRepository<Variant> Variants { get; }
        IBaseRepository<Answer> Answers { get; }
        void Save();
        void Dispose();
    }
}