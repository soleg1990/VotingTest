using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VotingTest.Web.Models
{
    public class VotingItemViewModel: BaseViewModel
    {
        [Required]
        [Display(Name = "Вопрос")]
        [DataType(DataType.MultilineText)]
        public string Title { get; set; }
        public VotingViewModel Voting { get; set; }
        public IList<VariantViewModel> Variants { get; set; }
    }
}