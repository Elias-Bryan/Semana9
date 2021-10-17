using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Semana9.Controllers
{
    public class HelloWorldController : Controller
    {
        public ActionResult Index(string Name, string LastName)
        {
            //
            //GET :/HelloWorld/

            ViewBag.FullName = String.Concat(Name, " ", LastName);
            return View();
        }

        public string Welcome(string name, int numTimes = 1) {
            return HttpUtility.HtmlEncode("Hello" + name + ",NumTimes is: " + numTimes);
        }
        
    }
}