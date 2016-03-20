
namespace VotingTest.DAL.Entities
{
    public class Answer : BaseEntity
    {
        public virtual User User { get; set; }
        public virtual Variant Variant { get; set; }
    }
}
