using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Friend_2019_11_13.Models
{
    public class Friend
    {
        //[Key]如果要把不是ID的名稱設定成KEY 可以有很多個[]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
    }
}