using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics_learning.CMS.Models
{
    internal class Student
    {
        public string FirstName = default;
        public string LastName = String.Empty;
        public int StudentId = 10000;
        public readonly int MaxEnrolledCourses = 3;
        public static int MaxBooksAllowed = 6;
        public Student()
        {
            Console.WriteLine("Student added...");
        }

        public int GetId()
        {
            return StudentId;
        }
        public string GetFullName() 
        {
            return $"{FirstName} {LastName}";
        }
    }
}
