using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeTest
{
    public class Snake
    {
        enum Direction { Up, Down, Left, Right }
        public int length {  get; set; }
        public Direction Direction { get; set; }
        public List<Point> Body { get; set; }

        public Snake(Point SnakePosition)
        {
            length = 1;
            Direction = Direction.Right;
            Body = new List<Point>();
            Body.Add(SnakePosition); // Initial position of the snake
        }
        public void Move()
        {
            // Logic to move the snake based on the current direction
        }

        public bool CheckCollision()
        {
            // Check if the snake collides with the given point
        }

        public void HandleUserInput(Keys keys)
        {
            // Logic to update snake direction
        }
    }

}
