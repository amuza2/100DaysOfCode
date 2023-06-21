using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FishGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void picPlayer_Click(object sender, EventArgs e)
        {
            
        }

        private void Direction_click(object sender, EventArgs e)
        {
            int x = picPlayer.Location.X;
            int y = picPlayer.Location.Y;
            switch (e.KeyCode)
            {
                case Keys.Left:
                    x -= 10;
                    break;
                case Keys.Right:
                    x += 10;
                    break;
                case Keys.Up:
                    y -= 10;
                    break;
                case Keys.Down:
                    y += 10;
                    break;
            }
            picPlayer.Location = new Point(x, y);
        }
    }
}
