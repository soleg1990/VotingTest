using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VotingTest.DAL.Entities
{
    public class Role : BaseEntity
    {
        [Index(IsUnique = true)]
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public virtual IList<User> Users { get; set; }

        public Role()
        {
            Users = new List<User>();
        }
    }
}
