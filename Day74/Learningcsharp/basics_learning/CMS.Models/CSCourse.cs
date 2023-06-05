using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics_learning.CMS.Models
{
    internal class CSCourse : ICours
    {
        public List<CourseSubject> Subjects => throw new NotImplementedException();

        public void AddSubject(CourseSubject subject)
        {
            throw new NotImplementedException();
        }

        public void AddSubject(List<CourseSubject> subjectsRange)
        {
            throw new NotImplementedException();
        }

        public void RemoveSubject(CourseSubject subject)
        {
            throw new NotImplementedException();
        }
    }
}
