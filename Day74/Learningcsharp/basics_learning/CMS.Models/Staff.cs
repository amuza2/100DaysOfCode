using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics_learning.CMS.Models
{
    internal class Staff
    {
        private string firstname;
        private string lastname;
        public string LastName { get { return lastname;} set { lastname = value; } }
        public string FirstName { get { return firstname; } set { firstname = value; } }

        public int Id { get; private set; }

        public void UpdateInfo(string firstname, string lastname = "")
        {
            FirstName = firstname;
            LastName = lastname;
        }
    }
}
