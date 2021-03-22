using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudManagement_MVC_frame.Models;

namespace StudManagement_MVC_frame.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult StudentDetails(int id)
        {
            //Student student = new Student
            //{
            //    StudID=1,
            //    StudGender = "Female",
            //    StudCity="CTC",
            //    StudName="SAMU"
            //};

            StudentContext studentContext = new StudentContext();
            Student student=studentContext.dbStudents.Single(stud => stud.StudID == id);
            return View(student);
        }

        public ActionResult Index()
        {
            StudentContext studentContext = new StudentContext();
            List<Student> studentsList= studentContext.dbStudents.ToList();
            return View(studentsList);
        }

        public ActionResult StudentbyDeptID(int deptID)
        {
            StudentContext studentContext = new StudentContext();
          List<Student> studentdeptlists = studentContext.dbStudents.Where(st => st.DepartmentID == deptID).ToList();
            return View (studentdeptlists);

        }
    }
}