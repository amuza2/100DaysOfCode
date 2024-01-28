using EntiryFrameworkCleanStart.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntiryFrameworkCleanStart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dbContxt = new PlutoDbContext();
            dbContxt.GetAuthorCourses();
            var courses = dbContxt.GetCourses();
            foreach (var item in courses)
            {
                Console.WriteLine(item.Title);
            }
        }
    }
}
