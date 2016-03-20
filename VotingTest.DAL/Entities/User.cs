using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VotingTest.DAL.Entities
{
    public class User : BaseEntity
    {
        [Index(IsUnique = true)]
        [Required]
        [MaxLength(50)]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }
        public virtual IList<Role> Roles { get; set; }

        public User()
        {
            Roles = new List<Role>();
        }
    }
}
