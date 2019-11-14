using Friend_2019_11_13.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Friend_2019_11_13.Views.ViewModel
{
    public class PeopleViewModel
    {
        public List<Employees> Employees { get; set; }
        public List<Friend>  Friends { get; set; }
    }
}