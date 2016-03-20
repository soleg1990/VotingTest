using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VotingTest.DAL.Entities
{
    public class Voting : BaseEntity
    {
        [Index(IsUnique = true)]
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }
        public virtual IList<VotingItem> Items { get; set; }

        public Voting()
        {
            Items = new List<VotingItem>();
        }
    }
}
