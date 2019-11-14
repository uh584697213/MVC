using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Friend_2019_11_13.Models
{
    public class Employees
    {
        [Display(Name = "員工編號")]
        public int Id { get; set; }
        [Display(Name = "員工名字")]

        public string Name { get; set; }
        [Display(Name = "員工電話")]

        public string Phone { get; set; }
        [Display(Name = "員工信箱")]

        public string Email { get; set; }
    }
}