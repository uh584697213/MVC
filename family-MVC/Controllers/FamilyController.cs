using family_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace family_MVC.Controllers
{
    public class FamilyController : Controller
    {
        // GET: FamilyMember
        public ActionResult Index()
        {
            List<Family> family = new List<Family>
            {
                new Family {ID = "A1234589",Name="AAA",Phone = "09345679",Age = 5,City="台北"},
                new Family {ID = "B1234589",Name="BBB",Phone = "095129",Age = 5,City="台中"},
                new Family {ID = "C1234589",Name="CCC",Phone = "095122879",Age = 5,City="台南"},
                new Family {ID = "D1234589",Name="DDD",Phone = "0951526",Age = 5,City="高雄"},
                new Family {ID = "E1234589",Name="EEE",Phone = "0954284",Age = 5,City="屏東"}
            };
            return View();
        }
    }
}