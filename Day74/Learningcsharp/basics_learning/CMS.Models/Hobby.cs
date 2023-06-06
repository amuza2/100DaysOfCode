using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics_learning.CMS.Models
{
    internal abstract class Hobby
    {
        private string name;
        public string GetHobbyName()
        {
            return name;
        }
        public abstract string GetTypeOfHobby();
    }

    public class Photography : Hobby
    {
        public override string GetTypeOfHobby()
        {
            throw new NotImplementedException();
        }
    }
}
