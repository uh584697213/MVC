using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace family_MVC.Models
{
    public class Family
    {
        //[Display (ID = "身分證字號")]
        public string ID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }
}