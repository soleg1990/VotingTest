using System.Collections.Generic;

namespace VotingTest.DAL.Entities
{
    public class Voting : BaseEntity
    {
        public string Name { get; set; }
        public virtual IList<VotingItem> Items { get; set; }
    }
}
