using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VotingTest.Web.Models
{
    public class UserEditModel
    {
        [Required]
        [MaxLength(20, ErrorMessage = "Недопустимая длина")]
        [Display(Name = "Логин")]
        public string Login { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "Длина пароля должна быть от 4 до 100 символов")]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        [DataType(DataType.Password)]
        [Display(Name = "Подтвердите пароль")]
        public string ConfirmPassword { get; set; }
    }
}