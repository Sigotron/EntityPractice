using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseRegistration
{
    public class Course
    {
        public Course()
        {
            Students = new List<Student>();
        }
        public int Cid { get; set; }
        public string Name { get; set; }
        public string RoomNumber { get; set; }
        public List<Student> Students { get; set; } // one course to many students
        public Instructor Instructor { get; set; } // one course to one instructor
    }
}
