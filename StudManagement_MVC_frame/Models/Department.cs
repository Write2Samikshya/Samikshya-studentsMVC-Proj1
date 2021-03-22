using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StudManagement_MVC_frame.Models
{
    [Table("Departments")]
    public class Department
    {
        [Key]
        public int DeptID { get; set; }
        public string DeptName { get; set; }
        public string DeptHead { get; set; }
        public int DeptStrength { get; set; }
        
        public List<Student> StudentsDept { get; set; }

    }
}