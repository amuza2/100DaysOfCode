using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeTest
{
    public class Food
    {
        public Point Position { get; set; }

        public Food()
        {
            Random rnd = new Random();
            Position = new Point(rnd.Next(0, 20), rnd.Next(0, 20)); // Random position within a 20x20 grid
        }
    }

}
