using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VotingTest.DAL.Entities
{
    public class VotingItem : BaseEntity
    {
        [Index(IsUnique = true)]
        [Required]
        [MaxLength(500)]
        public string Title { get; set; }
        [Required]
        public virtual Voting Voting { get; set; }
        public virtual IList<Variant> Variants { get; set; }

        public VotingItem()
        {
            Variants = new List<Variant>();
        }
    }
}
