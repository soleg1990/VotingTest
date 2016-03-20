using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VotingTest.DAL.Entities
{
    public class Variant : BaseEntity
    {
        [Index(IsUnique = true)]
        [Required]
        [MaxLength(200)]
        public string Text { get;set; }
        [DefaultValue(false)]
        public bool IsTrue { get; set; }
        [Required]
        public virtual VotingItem VotingItem { get; set; }
    }
}
