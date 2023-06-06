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
            Cours cours = new CSCourse();
            cours.AddSubject(new CourseSubject(301, "programming"));
        }
    }
}