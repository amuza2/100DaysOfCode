using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app1
{
    internal class TeamTreeHouseExceptions : Exception
    {
        public TeamTreeHouseExceptions()
        {
            
        }
        public TeamTreeHouseExceptions(string message) : base(message)
        {
            
        }
    }
    internal class OutOfBoundException : TeamTreeHouseExceptions
    {
        public OutOfBoundException()
        {
            
        }
        public OutOfBoundException(string message) : base(message)
        {
            
        }
    }
}
