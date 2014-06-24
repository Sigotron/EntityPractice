using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseRegistration;
using DataLayer;

namespace CourseRegistration
{
    class RunIt
    {
       public static void Main(string[] args)
        {
           Console.WriteLine("Hopefully Generating a Data Table");
           Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Context>());
            CreateDatabase();
        }

        private static void CreateDatabase()
        {
            // instructors
            var perkins = new Instructor() {Iid = 1, LastName = "Perkins"};
            var grossman = new Instructor() { Iid = 2, LastName = "Grossman" };
            var boriello = new Instructor() { Iid = 3, LastName = "Boriello" };
            var ceze = new Instructor() { Iid = 4, LastName = "Ceze" };
            // students
            var joel = new Student() {Sid = 9871571, FullName = "Joel Sigo"};
            var scottie = new Student() { Sid = 1111111, FullName = "Scottie Lim" };
            var matt = new Student() { Sid = 2222222, FullName = "Matt Wang" };
            var sethhampson = new Student() { Sid = 33333333, FullName = "Seth Hampson" };
            var sethpaulson = new Student() { Sid = 4444444, FullName = "Seth Paulson" };
            var chris = new Student() { Sid = 55555555, FullName = "Chris McKenzie" };
            // courses
            var cse344 = new Course {Cid = 344, Name = "CSE 344", RoomNumber = "EEB 114", Instructor = perkins};
            cse344.Students.Add(joel);
            cse344.Students.Add(sethhampson);
            var cse401 = new Course {Cid = 401, Name = "CSE 401", RoomNumber = "MGH 333", Instructor = grossman};
            cse401.Students.Add(scottie);
            var cse352 = new Course() {Cid = 352, Name = "CSE 352", RoomNumber = "MGH 220", Instructor = boriello};
            cse352.Students.Add(matt);
            var cse454 = new Course() {Cid = 454, Name = "CSE 454", RoomNumber = "EEB 220", Instructor = ceze};
            cse454.Students.Add(sethpaulson);
            cse454.Students.Add(chris);
            // create new context
            var db = new Context();
            // add students
            db.Students.Add(joel);
            db.Students.Add(scottie);
            db.Students.Add(matt);
            db.Students.Add(sethhampson);
            db.Students.Add(sethpaulson);
            db.Students.Add(chris);
            // add instructors
            db.Instructors.Add(perkins);
            db.Instructors.Add(grossman);
            db.Instructors.Add(boriello);
            db.Instructors.Add(ceze);
            // add courses
            db.Courses.Add(cse352);
            db.Courses.Add(cse344);
            db.Courses.Add(cse401);
            db.Courses.Add(cse454);
            // save changes
            db.SaveChanges();
            Console.WriteLine("Generated?");
        }
    }
}
