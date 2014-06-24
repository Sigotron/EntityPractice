using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using CourseRegistration;

namespace DataLayer
{
    public class Context: DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasKey(b => b.Sid);
            modelBuilder.Entity<Instructor>().HasKey(b => b.Iid);
            modelBuilder.Entity<Course>().HasKey(b => b.Cid);
        }
    }

    
}
