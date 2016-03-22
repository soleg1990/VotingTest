using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VotingTest.Web.Models
{
    public class VotingViewModel : BaseViewModel
    {
        [Required(ErrorMessage = "Введите название")]
        [MaxLength(100, ErrorMessage = "Превышена допустимая длина")]
        [Display(Name = "Название")]
        public string Name { get; set; }
        public IList<VotingItemViewModel> Items { get; set; }
    }
}