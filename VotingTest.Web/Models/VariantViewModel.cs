using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VotingTest.Web.Models
{
    public class VariantViewModel: BaseViewModel
    {
        [Required]
        [MaxLength(100)]
        [Display(Name = "Вариант ответа")]
        public string Text { get; set; }
        [Display(Name = "Верный")]
        public bool IsTrue { get; set; }
        public virtual VotingItemViewModel VotingItem { get; set; }
    }
}