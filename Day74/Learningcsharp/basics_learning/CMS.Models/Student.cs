using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics_learning.CMS.Models
{
    internal class Student : Person
    {
        public List<string> Hobbies { get; set; }
        public int StudentId = 10000;
        public readonly int MaxEnrolledCourses = 3;
        public static int MaxBooksAllowed = 6;

        public Student()
        {
            Console.WriteLine("student created!");
        }

        public Student(string firstname, string lastname) : base(firstname, lastname)
        {
            Console.WriteLine("Student added...");
        }

        public int GetId()
        {
            return StudentId;
        }
        public override string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
