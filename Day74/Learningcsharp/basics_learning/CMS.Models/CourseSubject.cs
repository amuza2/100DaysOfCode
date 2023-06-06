using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics_learning.CMS.Models
{
    internal class CourseSubject
    {
        public int Id;
        public string SubjectName;

        public CourseSubject(int id, string name) 
        { 
            Id = id;
            SubjectName = name;
        }
    }
}
