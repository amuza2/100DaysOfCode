using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics_learning.CMS.Models
{
    internal class CSCourse : Cours
    {
        public sealed override void AddSubject(CourseSubject subject)
        {
            Console.WriteLine("Calling Cours.AddSubject(CourseSubject)");
            base.AddSubject(subject);
        }
    }
}
