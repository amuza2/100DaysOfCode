namespace SnakeTest
{
    public partial class Form1 : Form
    {
        enum GameBoardGame { Free, Snake, Bonus };
        enum Directions { Left, Right, Up, Down };
        struct SnakeCoordinates
        {
            public int x; public int y;
        }
        Graphics g;
        Random rand;
        GameBoardGame[,] board;
        SnakeCoordinates[] SnakeXY;
        Directions direction;
        int SnakeLength;
        public Form1()
        {
            InitializeComponent();
            board = new GameBoardGame[11, 11];
            SnakeXY = new SnakeCoordinates[100];
            rand = new Random();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            picGameBoard.Image = new Bitmap(420, 420);
            g = Graphics.FromImage(picGameBoard.Image);
            g.Clear(Color.White);

            // Draw the walls
            for (int i = 1; i < 11; i++)
            {
                g.DrawImage(imageList.Images[0], i * 35, 0);
                g.DrawImage(imageList.Images[0], i * 35, 385);
            }
            for (int i = 0; i <= 11; i++)
            {
                g.DrawImage(imageList.Images[0], 0, i * 35);
                g.DrawImage(imageList.Images[0], 385, i * 35);
            }

            // set snake position
            SnakeXY[0].x = 5;
            SnakeXY[0].y = 5;
            SnakeXY[1].x = 5;
            SnakeXY[1].y = 6;
            SnakeXY[2].x = 5;
            SnakeXY[2].y = 7;

            // Draw snake in the board
            g.DrawImage(imageList.Images[6], SnakeXY[0].x * 35, SnakeXY[0].y * 35);
            g.DrawImage(imageList.Images[5], SnakeXY[1].x * 35, SnakeXY[1].y * 35);
            g.DrawImage(imageList.Images[5], SnakeXY[2].x * 35, SnakeXY[2].y * 35);

            // fill the board with x,y of snake body
            board[SnakeXY[0].x, SnakeXY[0].y] = GameBoardGame.Snake;
            board[SnakeXY[1].x, SnakeXY[1].y] = GameBoardGame.Snake;
            board[SnakeXY[2].x, SnakeXY[2].y] = GameBoardGame.Snake;

            // Draw bonues
            for (int i = 0; i < 4; i++)
            {
                Bonus();
            }

            // set up direction by as default
            direction = Directions.Up;
            // set snake length
            SnakeLength = 3;

        }
        // Settting up game bonuses
        private void Bonus()
        {
            int randomPositionX;
            int randomPositionY;
            int imageIndex = rand.Next(1, 5);
            do
            {
                randomPositionX = rand.Next(1, 10);
                randomPositionY = rand.Next(1, 10);

            } while (board[randomPositionX, randomPositionY] != GameBoardGame.Free);

            board[randomPositionX, randomPositionY] = GameBoardGame.Bonus;
            g.DrawImage(imageList.Images[imageIndex], randomPositionX * 35, randomPositionY * 35);
        }

        private void Key_Pressed(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    direction = Directions.Up;
                    break;
                case Keys.Down:
                    direction = Directions.Down;
                    break;
                case Keys.Left:
                    direction = Directions.Left;
                    break;
                case Keys.Right:
                    direction = Directions.Right;
                    break;
            }
            bool isActive = false;
            if(e.KeyCode == Keys.Space && isActive == false)
            {
                isActive = true;
                timer.Enabled = true;
            }
        }

        // Stop the game
        private void GameOver()
        {
            timer.Enabled = false;
            MessageBox.Show("Game Over", "You lost", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            g.FillRectangle(Brushes.White, SnakeXY[SnakeLength - 1].x * 35, SnakeXY[SnakeLength - 1].y * 35, 35, 35);
            board[SnakeXY[SnakeLength - 1].x, SnakeXY[SnakeLength - 1].y] = GameBoardGame.Free;
            // Move the snake body to new position
            for (int i = SnakeLength - 1; i >= 1; i--)
            {
                SnakeXY[i].x = SnakeXY[i - 1].x;
                SnakeXY[i].y = SnakeXY[i - 1].y;
            }
            g.DrawImage(imageList.Images[5], SnakeXY[0].x * 35, SnakeXY[0].y * 35);


            // Change the direction of the head
            switch (direction)
            {
                case Directions.Left:
                    SnakeXY[0].x--;
                    break;
                case Directions.Right:
                    SnakeXY[0].x++;
                    break;
                case Directions.Up:
                    SnakeXY[0].y--;
                    break;
                case Directions.Down:
                    SnakeXY[0].y++;
                    break;
            }

            // Check if the snake hit a wall or it's awn body
            if (SnakeXY[0].x < 1 || SnakeXY[0].x > 10 || SnakeXY[0].y < 1 || SnakeXY[0].y > 10
                || board[SnakeXY[0].x, SnakeXY[0].y] == GameBoardGame.Snake)
            {
                GameOver();
                return;
            }
            // Check if snake ate a bonus
            if (board[SnakeXY[0].x, SnakeXY[0].y] == GameBoardGame.Bonus)
            {
                board[SnakeXY[0].x, SnakeXY[0].y] = GameBoardGame.Snake;
                g.DrawImage(imageList.Images[5], SnakeXY[SnakeLength].x * 35, SnakeXY[SnakeLength].y * 35);
                SnakeLength++;

                // Create a bonus if one is eaten
                if(SnakeLength > 96) 
                {
                    Bonus();
                }
                // Add score
                this.Text = "Snake Game Test - Score: " + SnakeLength;
            }

            picGameBoard.Refresh();
        }
    }
}