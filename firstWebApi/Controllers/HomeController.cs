using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace firstWebApi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var mvcName = typeof(Controller).Assembly.GetName();
            var isMono = Type.GetType("Mono.Runtime") != null;

            ViewData["Version"] = mvcName.Version.Major + "." + 
            mvcName.Version.Minor;
            ViewData["Runtime"] = isMono ? "Mono" : ".NET";
            Dictionary<string, string> cd = new Dictionary<string, string>();
            for(int i = 0; i < 10; i++)
            {
                cd.Add(System.Convert.ToString(i), "a");
            }
            ViewData["ownProperty"] = cd.Count;

            return View();
        }
    }
}
