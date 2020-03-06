using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCForm.Models;

namespace MVCForm.Controllers
{
    public class HomeController : Controller
    {
        public static List<Student> ListStudent=new List<Student>();
        // GET: Home
        public ActionResult Index()
        {
            var student = from e in ListStudent orderby e.StudentID select e;
            return View(student);
        }

        [HttpPost]
        public ActionResult AddRow(FormCollection form)
        {
            Student std = new Student();
            std.StudentID = Convert.ToInt32(form["StudentID"]);
            std.FirstName = form["FirstName"];
            ListStudent.Add(std);
            return RedirectToAction("Index");
        }
    }
}