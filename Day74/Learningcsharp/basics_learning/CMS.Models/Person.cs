using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics_learning.CMS.Models
{
    internal class Person
    {
        private protected string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public Person() { }

        public Person(string firstname, string lastname) 
        {
            Console.WriteLine("Person Created!");
            FirstName = firstname;
            LastName = lastname;
        }
    }
}
