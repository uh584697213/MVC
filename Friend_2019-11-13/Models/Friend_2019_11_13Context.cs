using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Friend_2019_11_13.Models
{
    public class Friend_2019_11_13Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Friend_2019_11_13Context() : base("name=Friend_2019_11_13Context")
        {
        }

        public DbSet<Friend_2019_11_13.Models.Friend> Friends { get; set; }
        public DbSet<Friend_2019_11_13.Models.Employees> Employees { get; set; }

        public System.Data.Entity.DbSet<Friend_2019_11_13.Models.Info> Infoes { get; set; }
    }
}