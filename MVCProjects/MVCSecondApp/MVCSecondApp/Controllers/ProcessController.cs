using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCSecondApp.Models;

namespace MVCSecondApp.Controllers
{
    public class ProcessController : Controller
    {
        // GET: Process
        public string List()
        {
            return "List method in the Process Controller";
        }

        public string GetAllCustomers()
        {
            return @"<ul>
                      <li>Ali Raza</li>
                      <li>Mark Upston</li>
                      <li>Allan Bommer</li>
                      <li>Greg Jerry</li>
                   </ul>";
        }
        

        public static List<Employee> empList = new List<Employee>{
           new Employee{
              ID = 1,
              Name = "Allan",
              JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
              Age = 23
           },

           new Employee{
              ID = 2,
              Name = "Carson",
              JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
              Age = 45
           },

           new Employee{
              ID = 3,
              Name = "Carson",
              JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
              Age = 37
           },

           new Employee{
              ID = 4,
              Name = "Laura",
              JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
              Age = 26
           },

        };
        public ActionResult Index()
        {
            var employees = from e in empList
                            orderby e.ID
                            select e;
            return View(employees);
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            //List<Employee> empList = empList;
            var employee = empList.Single(m => m.ID == id);
            return View(employee);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                var employee = empList.Single(m => m.ID == id);
                if (TryUpdateModel(employee))
                {
                    //To Do:- database code
                    return RedirectToAction("Index");
                }
                return View(employee);
            }
            catch
            {
                return View();
            }
        }
        
    }   
}