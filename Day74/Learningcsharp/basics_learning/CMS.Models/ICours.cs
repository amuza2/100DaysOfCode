using System.Collections.Generic;

namespace basics_learning.CMS.Models
{
    internal interface ICours
    {
        int TotalSubjects
        {
            get
            {
                return Subjects.Count;
            }
        }
        List<CourseSubject> Subjects { get; }

        void AddSubject(CourseSubject subject);
        void AddSubject(List<CourseSubject> subjectsRange);
        void RemoveSubject(CourseSubject subject);
        int GetTotalElectives()
        {
            return 0;
        }
    }
}