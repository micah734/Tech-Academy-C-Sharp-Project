using System;
using System.Data.Entity;

namespace StudentDb
{
    class Program
    {
        static void Main(string[] args)
        { 
            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { StudentFName = "Bob", StudentLName = "Jobs", Grade = 8 };

                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }
        }
    }

    public class Student
    {
        public int StudentId { get; set; }
        public string StudentFName { get; set; }
        public string StudentLName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int Grade { get; set; }
    }

    public class SchoolContext : DbContext
    {
        public SchoolContext() : base()
        {

        }

        public DbSet<Student> Students { get; set; }
    }
}
