using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Friend_2019_11_13.Models
{
    public class Info
    {
        
        public int Id { get; set; }
        [Required (ErrorMessage ="名稱必須輸入")]
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
    }
}