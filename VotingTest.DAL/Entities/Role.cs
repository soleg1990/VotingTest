using System.Collections.Generic;

namespace VotingTest.DAL.Entities
{
    public class Role : BaseEntity
    {
        public string Name { get; set; }
        public virtual IList<User> Users { get; set; }

        public Role()
        {
            Users = new List<User>();
        }
    }
}
