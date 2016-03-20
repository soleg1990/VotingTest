using System.Collections.Generic;

namespace VotingTest.DAL.Entities
{
    public class User : BaseEntity
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public virtual IList<Role> Roles { get; set; }
    }
}
