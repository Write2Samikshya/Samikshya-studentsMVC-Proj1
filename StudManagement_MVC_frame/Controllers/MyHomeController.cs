using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudManagement_MVC_frame.Controllers
{
    public class MyHomeController : Controller
    {
        // GET: MyHome
        public ActionResult Index()
        {
            ViewBag.departments = new List<string>()
            {
                "IT",
                "HR",
                "MEDICO",
                "PAYROL"
            };


            return View();
        }
    }
}