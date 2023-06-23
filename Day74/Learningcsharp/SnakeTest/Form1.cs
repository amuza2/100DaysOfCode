namespace SnakeTest
{
    public partial class Form1 : Form
    {
        private Snake snake;
        private Food food;
        private Game game;

        public Form1()
        {
            InitializeComponent();
            // Create instances of the Snake, Food and Game classes
            snake = new Snake(new Point(10, 10)); // Start in the middle of a 20x20 grid
            food = new Food();
            game = new Game(snake, food);

            timer.Tick += GameLoop;
            timer.Start();

            // setup the game board
            picBoardGame.Image = new Bitmap(picBoardGame.Width, picBoardGame.Height);
            game.DrawGameBoard(Graphics.FromImage(picBoardGame.Image));

            timer.Start();
        }

        private void GameLoop(object sender, EventArgs e)
        {
            snake.Move();
            if (snake.CheckCollision())
            {
                timer.Stop();
                MessageBox.Show("Game Over");
                // Logic to restart the game
            }

            if (food.CheckCollision(snake.Body[0]))
            {
                // Logic to handle collision between the snake and food
            }
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            snake.HandleUserInput(e.KeyCode);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        
    }
}