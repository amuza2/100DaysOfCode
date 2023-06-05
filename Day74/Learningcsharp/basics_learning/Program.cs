using basics_learning;
using basics_learning.CMS.Display;
using basics_learning.CMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            Cours c1 = new Cours()
            {
                CourseId = 1,
                CourseName = "C#"
            };
            Student student1 = new Student()
            {
                FirstName = "Test",
                LastName = "Test2",
                StudentId = 001
            };
            Console.WriteLine(student1.GetId());
            Console.WriteLine(student1.GetFullName());

            ICours csCourse = new CSCourse()
            {

            };
        }
    }
}