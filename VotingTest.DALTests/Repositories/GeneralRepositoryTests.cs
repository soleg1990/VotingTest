using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VotingTest.DAL.Entities;
using VotingTest.DAL.Repositories;

namespace VotingTest.DAL.Tests.Repositories
{
    [TestClass()]
    public class GeneralRepositoryTests
    {
        private string connectionString;
        private GeneralRepository db;
        [TestInitialize()]
        public void BeforeTests()
        {
            connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=VotingTestTest;Integrated Security=True;Pooling=False";
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

            Assert.IsTrue(db.Roles.GetAll().Count() == 1);
            Assert.IsTrue(db.Users.GetAll().Count() == 1);
        }
    }
}