using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudManagement_MVC_frame.Models;

namespace StudManagement_MVC_frame.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        public ActionResult Index()
        {
            DepartmentContext studentDeptContext = new DepartmentContext();
            List<Department> departments= studentDeptContext.dbdepartments.ToList();
            return View(departments);
        }
    }
}