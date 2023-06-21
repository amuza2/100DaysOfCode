namespace SnakeTest
{
    public partial class Form1 : Form
    {
        private Snake snake;
        private Food food;

        public Form1()
        {
            InitializeComponent();
            snake = new Snake(new Point(10, 10)); // Start in the middle of a 20x20 grid
            food = new Food();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            snake.Move();

            // Check for collision with food
            if (snake.Body[0] == food.Position)
            {
                // Add the food to the snake's body and create new food
                snake.Body.Add(food.Position);
                food = new Food();
            }

            // Check for collision with self or wall
            if (snake.Body.Skip(1).Contains(snake.Body[0]) || snake.Body[0].X < 0 || snake.Body[0].Y < 0 || snake.Body[0].X >= 20 || snake.Body[0].Y >= 20)
            {
                timer.Stop();
                MessageBox.Show("Game Over");
            }
        }

    }
}