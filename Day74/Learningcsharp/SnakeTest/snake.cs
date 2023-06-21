using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeTest
{
    public class Snake
    {
        public List<Point> Body { get; set; }
        public Point Direction { get; set; }

        public Snake(Point startingPosition)
        {
            Body = new List<Point> { startingPosition };
            Direction = new Point(0, 1); // Start by moving down
        }

        public void Move()
        {
            // Add a new head to the snake in the current direction
            Body.Insert(0, new Point(Body[0].X + Direction.X, Body[0].Y + Direction.Y));

            // Remove the tail of the snake
            Body.RemoveAt(Body.Count - 1);
        }
    }

}
