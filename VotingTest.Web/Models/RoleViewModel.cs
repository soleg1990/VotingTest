using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VotingTest.Web.Models
{
    public class RoleViewModel
    {
        [Required]
        [Display(Name = "Роль")]
        public string Name { get; set; }
        public virtual IList<UserViewModel> Users { get; set; }
    }
}