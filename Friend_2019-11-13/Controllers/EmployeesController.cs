using Friend_2019_11_13.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Friend_2019_11_13.Controllers
{
    public class EmployeesController : Controller
    {
        private HRContext db = new HRContext();

        // GET: Employees
        public ActionResult Index()
        {
            return View(db.Employees.ToList());
        }
    }
}