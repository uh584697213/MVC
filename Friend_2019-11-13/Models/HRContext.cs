using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Friend_2019_11_13.Models
{
    public class HRContext : DbContext
    {
        public HRContext() : base("name=HRDatabase")
        {
        }
        public DbSet<Friend> Friends { get; set; }
        public DbSet<Employees> Employees { get; set; }

    }
}