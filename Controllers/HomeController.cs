using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        readonly Models.FinancesContext db = new Models.FinancesContext();

        public ActionResult Index()
        {
            IEnumerable<Group> groups = db.Groups;
            ViewBag.Groups = groups;
            return View();
        }

        [HttpGet]
        public ActionResult AddPerson()
        {
            return View();
        }

        [HttpPost]
        public string AddPerson(AddStudent add)
        {
            db.AddStudents.Add(add); db.SaveChanges();
            return "Student " + add.Name + " added";
        }
    }
}