using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webb2.Controllers
{
    public class HomeController : Controller
    {

        //public string Index()
        //{
        //    return "Hello from webserver";
        //}

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}