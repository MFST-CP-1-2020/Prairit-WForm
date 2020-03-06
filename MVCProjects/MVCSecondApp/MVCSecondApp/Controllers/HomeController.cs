using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSecondApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        /*public string Index()
        {
            return "Hello World!";
        }*/
        public ActionResult Index()
        {
            return RedirectToAction("GetAllCustomers", "Process");
        }

        [ActionName("CurrentTime")]
        public string getCurrentTime()
        {
            return Time();
        }

        [NonAction]
        public string Time()
        {
            return "Time is"+DateTime.Now.ToString("T");
        }

        public ActionResult name(string str)
        {
            var input = Server.HtmlEncode(str);
            return Content(input);
        }

        [HttpGet]
        public ActionResult name()
        {
            var input = "No input";
            return Content(input);
        }

        public ActionResult myView()
        {
            return View();
        }

    }
}