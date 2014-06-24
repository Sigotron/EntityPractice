using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CourseRegistration
{
    public class Student
    {
        public int Sid { get; set; }
        public String FullName { get; set; }
    }
}
