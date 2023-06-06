using System.Collections.Generic;

namespace basics_learning.CMS.Models
{
    internal interface ICours
    {
        List<CourseSubject> Subjects { get; }

        void AddSubject(CourseSubject subject);
        void AddSubject(List<CourseSubject> subjectsRange);
        void RemoveSubject(CourseSubject subject);
    }
}