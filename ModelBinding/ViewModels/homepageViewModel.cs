using ModelBinding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModelBinding.ViewModels
{
    public class homepageViewModel
    {
        public People PeopleObject { get; set; }
        public Address AddressObject { get; set; }
    }
}