using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleForm.Models
{
    public class Person
    {
        public string Married { get; set; }
        public bool Check { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Multiline { get; set; }
        public IEnumerable<string> ChooseFromList { get; set; }
        public IEnumerable<string> ChooseOneFromList { get; set; }
        public IEnumerable<string> ChooseMultipleFromList { get; set; }
    }

}