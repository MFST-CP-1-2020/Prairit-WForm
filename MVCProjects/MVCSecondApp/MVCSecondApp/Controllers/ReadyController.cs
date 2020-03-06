using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCSecondApp.ActionFilter;

namespace MVCSecondApp.Controllers
{
    [MyLogActionFilter]
    public class ReadyController : Controller
    {
        // GET: Ready
        public string List()
        {
            return "In List function of ReadyController";
        }

        public string search(string name)
        {
            var input = Server.HtmlEncode(name);
            return input;
        }

        
    }
}