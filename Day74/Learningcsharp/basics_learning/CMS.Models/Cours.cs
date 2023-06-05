using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics_learning.CMS.Models
{
    internal class Cours : ICours
    {
        private List<CourseSubject> subjects = new List<CourseSubject>();
        public List<CourseSubject> Subjects { get { return subjects; } private set { subjects = value; } }
        public int CourseId;
        public string CourseName;
        public static int MaxSubject = 8;

        public void AddSubject(CourseSubject subject)
        {
            subjects.Add(subject);
        }

        public void AddSubject(List<CourseSubject> subjectsRange)
        {
            Subjects.AddRange(subjectsRange);
        }

        public void RemoveSubject(CourseSubject subject)
        {
            Subjects.Remove(subject);
        }
    }
}
