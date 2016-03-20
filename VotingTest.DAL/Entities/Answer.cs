
using System.ComponentModel.DataAnnotations;

namespace VotingTest.DAL.Entities
{
    public class Answer : BaseEntity
    {
        [Required]
        public virtual User User { get; set; }
        [Required]
        public virtual Variant Variant { get; set; }
    }
}
