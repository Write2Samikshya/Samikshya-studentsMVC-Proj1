using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace StudManagement_MVC_frame.Models
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> dbStudents { get; set; }
    }


    public class DepartmentContext : DbContext
    {
        public DbSet<Department> dbdepartments { get; set; }
    }

} 