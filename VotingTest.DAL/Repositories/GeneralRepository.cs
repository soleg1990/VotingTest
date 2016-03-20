using VotingTest.DAL.Entities;
using VotingTest.DAL.EntityFramework;
using VotingTest.DAL.Interfaces;

namespace VotingTest.DAL.Repositories
{
    public class GeneralRepository : IGeneralRepository
    {
        private readonly EFdbContext _db;
        private IBaseRepository<Role> _roleRepository;
        private IBaseRepository<User> _userRepository;
        private IBaseRepository<Voting> _votingRepository;
        private IBaseRepository<VotingItem> _itemRepository;
        private IBaseRepository<Variant> _variantRepository;
        private IBaseRepository<Answer> _answerRepository;

        public GeneralRepository(string connectionString)
        {
            _db = new EFdbContext(connectionString);
        }
        public IBaseRepository<Role> Roles
        {
            get { return (_roleRepository ?? (_roleRepository = new BaseRepository<Role>(_db))); }
        }
        public IBaseRepository<User> Users
        {
            get { return (_userRepository ?? (_userRepository = new BaseRepository<User>(_db))); }
        }

        public IBaseRepository<Voting> Votings
        {
            get { return (_votingRepository ?? (_votingRepository = new BaseRepository<Voting>(_db))); }
        }

        public IBaseRepository<VotingItem> Items
        {
            get { return (_itemRepository ?? (_itemRepository = new BaseRepository<VotingItem>(_db))); }
        }

        public IBaseRepository<Variant> Variants
        {
            get { return (_variantRepository ?? (_variantRepository = new BaseRepository<Variant>(_db))); }
        }

        public IBaseRepository<Answer> Answers
        {
            get { return (_answerRepository ?? (_answerRepository = new BaseRepository<Answer>(_db))); }
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public virtual void Dispose()
        {
            _db?.Dispose();
        }
    }
}
