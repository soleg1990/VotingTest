using System.ComponentModel;

namespace VotingTest.DAL.Entities
{
    public class Variant : BaseEntity
    {
        public string Text { get;set; }
        [DefaultValue(false)]
        public bool IsTrue { get; set; }
        public virtual VotingItem VotingItem { get; set; }
    }
}
