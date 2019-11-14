using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Friend_2019_11_13.Models
{
    public class CarDBContext : DbContext
    {
        public CarDBContext() : base("name=CarDB")
        {
        }
        public DbSet<Info> Infoes { get; set; }
    }
}