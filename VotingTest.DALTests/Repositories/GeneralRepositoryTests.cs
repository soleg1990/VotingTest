using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VotingTest.DAL.Entities;
using VotingTest.DAL.EntityFramework;
using VotingTest.DAL.Repositories;

namespace VotingTest.DAL.Tests.Repositories
{
    [TestClass()]
    public class GeneralRepositoryTests
    {
        IGeneralRepository db;
        private readonly string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=VotingTestTest;Integrated Security=True;Pooling=False";

        [TestInitialize()]
        public void BeforeTests()
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<EFdbContext>());
            db = new GeneralRepository(connectionString);
        }

        [TestCleanup()]
        public void AfterTests()
        {
            db.Dispose();
        }

        [TestMethod()]
        public void CreateRoleWithUserTest()
        {
            User user = new User() {Login = "Admin", Password = "1234"};
            Role role = new Role() {Name = "Admin"};
            role.Users.Add(user);

            db.Roles.Create(role);
            db.Save();
            var dbRole = db.Roles.Get(role.Id);
            var dbUser = db.Users.Get(user.Id);

            Assert.IsFalse(dbRole == null);
            Assert.IsFalse(dbUser == null);

        }
        [TestMethod()]
        [ExpectedException(typeof(DbUpdateException))]
        public void TryToAddSameRole()
        {
            Role role = new Role() { Name = "SameRole" };
            Role role1 = new Role() { Name = "SameRole" };

            db.Roles.Create(role);
            db.Save();
            db.Roles.Create(role1);
            db.Save();
        }

        [TestMethod()]
        public void AddVotingTest()
        {
            Voting v = new Voting() {Name = "Test"};
            VotingItem vi = new VotingItem() {Title = "Test"};
            Variant vr = new Variant() {Text = "Test"};
            vi.Variants.Add(vr);
            v.Items.Add(vi);
            db.Votings.Create(v);
            db.Save();

            var dbVoting = db.Votings.Get(v.Id);
            var dbItem = db.Items.Get(vi.Id);
            var dbVariant = db.Variants.Get(vr.Id);

            Assert.IsFalse(dbVoting == null);
            Assert.IsFalse(dbItem == null);
            Assert.IsFalse(dbVariant == null);
        }

        [TestMethod()]
        public void DeleteVotingTest()
        {
            Voting v = new Voting() { Name = "DeleteTest" };
            VotingItem vi = new VotingItem() { Title = "DeleteTest" };
            Variant vr = new Variant() { Text = "DeleteTest" };
            vi.Variants.Add(vr);
            v.Items.Add(vi);
            db.Votings.Create(v);
            db.Save();
            db.Votings.Delete(v.Id);
            db.Save();

            var dbVoting = db.Votings.Get(v.Id);
            var dbItem = db.Items.Get(vi.Id);
            var dbVariant = db.Variants.Get(vr.Id);

            Assert.IsTrue(dbVoting == null);
            Assert.IsTrue(dbItem == null);
            Assert.IsTrue(dbVariant == null);
        }
    }
}