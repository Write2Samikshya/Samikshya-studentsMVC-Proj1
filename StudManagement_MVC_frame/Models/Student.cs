using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StudManagement_MVC_frame.Models
{
    [Table("Students")]
    public class Student
    {
        [Key]
        public int StudID { get; set; }
        public string StudName { get; set; }
        public string StudCity { get; set; }

        public string StudGender { get; set; }
        //[NotMapped]
        public int DepartmentID { get; set; }

    }
}