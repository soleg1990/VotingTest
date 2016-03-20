using System.Collections.Generic;

namespace VotingTest.DAL.Entities
{
    public class VotingItem : BaseEntity
    {
        public string Title { get; set; }
        public virtual Voting Voting { get; set; }
        public virtual IList<Variant> Variants { get; set; }
    }
}
