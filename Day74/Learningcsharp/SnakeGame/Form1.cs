using System.IO.Pipes;

namespace SnakeGame
{
    public partial class Form1 : Form
    {
        Random rand;
        enum GameBoardFields
        {
            Free, Snake, Bonus
        };
        enum Directions
        {
            Up, Down, Left, Right
        };
        struct SnakeCoordinates
        {
            public int x;
            public int y;
        }
        GameBoardFields[,] gameBoardField;
        SnakeCoordinates[] snakeXY;
        int snakeLength;
        Directions direction;
        Graphics g;
        public Form1()
        {
            InitializeComponent();
            gameBoardField = new GameBoardFields[11, 11];
            snakeXY = new SnakeCoordinates[100];
            rand = new Random();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            picBoardGame.Image = new Bitmap(420, 420);
            g = Graphics.FromImage(picBoardGame.Image);
            g.Clear(Color.White);

            for (int i = 1; i <= 10; i++)
            {
                // Draw top and bottom walls
                g.DrawImage(imgList.Images[6], i * 35, 0);
                g.DrawImage(imgList.Images[6], i * 35, 385);
            }
            for (int i = 0; i <= 11; i++)
            {
                // Draw left nad bottom walls
                g.DrawImage(imgList.Images[6], 0, i * 35);
                g.DrawImage(imgList.Images[6], 385, i * 35);
            }

            // Initialize body and head
            snakeXY[0].x = 5; // head
            snakeXY[0].y = 5;
            snakeXY[1].x = 5; // second body part
            snakeXY[1].y = 6;
            snakeXY[2].x = 5; // third body part
            snakeXY[2].y = 7;

            g.DrawImage(imgList.Images[5], 5 * 35, 5 * 35); // head
            g.DrawImage(imgList.Images[4], 5 * 35, 6 * 35); // first body part
            g.DrawImage(imgList.Images[4], 5 * 35, 7 * 35); // second body part

            gameBoardField[5, 5] = GameBoardFields.Snake;
            gameBoardField[5, 6] = GameBoardFields.Snake;
            gameBoardField[5, 7] = GameBoardFields.Snake;

            direction = Directions.Up;
            snakeLength = 3;

            for (int i = 0; i < 4; i++)
            {
                Bonus();
            }
        }

        private void Bonus()
        {
            int x, y;
            int imgIndex = rand.Next(4);

            do
            {
                x = rand.Next(1, 10);
                y = rand.Next(1, 10);
            } while (gameBoardField[x, y] != GameBoardFields.Free);

            gameBoardField[x, y] = GameBoardFields.Bonus;
            g.DrawImage(imgList.Images[imgIndex], x * 35, y * 35);

        }

        private void frmSnake_KeyDown(object sender, KeyEventArgs e)
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
        }
        private void GameOver()
        {
            timer.Enabled = false;
            MessageBox.Show("Game Over", "End Game");
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Delete the end of the snake part
            g.FillRectangle(Brushes.Black, snakeXY[snakeLength - 1].x * 35, snakeXY[snakeLength - 1].y * 35,
                                            35, 35);
            // Make the end of the snake as a Free space
            gameBoardField[snakeXY[snakeLength - 1].x, snakeXY[snakeLength - 1].y] = GameBoardFields.Free;
            //picBoardGame.Refresh();

            // Move Snake field on the previous position
            for (int i = snakeLength; i >= 1; i--)
            {
                snakeXY[i].x = snakeXY[i - 1].x;
                snakeXY[i].y = snakeXY[i - 1].y;
            }
            g.DrawImage(imgList.Images[4], snakeXY[0].x * 35, snakeXY[0].y * 35);

            // Change direction of the head
            switch (direction)
            {
                case Directions.Up:
                    snakeXY[0].y = snakeXY[0].y - 1;
                    break;
                case Directions.Down:
                    snakeXY[0].y = snakeXY[0].y + 1;
                    break;
                case Directions.Left:
                    snakeXY[0].x = snakeXY[0].x - 1;
                    break;
                case Directions.Right:
                    snakeXY[0].x = snakeXY[0].x + 1;
                    break;
            }

            // Check if snake hit the wall




        }
    }
}