using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeTest
{
    public class Game
    {
        public Game(Snake snake, Food food)
        {
            Snake = snake;
            Food = food;
        }

        public Snake Snake { get; set; }
        public Food Food { get; set; }

        public void Start()
        {
            // Start the game
        }
        public void End() 
        { 
            // End the game
        }
        public void MoveSnake()
        {
            // Move the snake and check for collisions
        }
        public bool CheckCollisions()
        {
            // Check for Collisions between the snake and the game board or food
            return false;
        }

        public void DrawGameBoard(Graphics g)
        {
            g.Clear(Color.White);
        }

        public void Score()
        {
            // Add score
        }
    }
}
