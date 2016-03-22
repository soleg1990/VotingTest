using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VotingTest.Web.Models
{
    public class UserViewModel: BaseViewModel
    {
        [Required]
        [MaxLength(20)]
        [Display(Name = "Логин")]
        public string Login { get; set; }
        public virtual IList<RoleViewModel> Roles { get; set; }
    }
}