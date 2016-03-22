using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VotingTest.Web.Models
{
    public class BaseViewModel
    {
        [HiddenInput(DisplayValue = false)]
        public Guid Id { get; set; }
    }
}