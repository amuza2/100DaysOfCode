using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tbPrice.Text = 2000.ToString();


        }
        int fee = 2000;
        int PriceToPay = 2000;
        int volant = 8000;
        int wheel = 5000;
        int direction = 12000;
        int brakes = 4000;
        int abs = 5;
        
        
        void CheckCheckBox(CheckBox c, int priceVariable)
        {
            if (c.Checked)
            {
                PriceToPay += priceVariable;
                tbPrice.Text = PriceToPay.ToString();
            }
            else
            {
                PriceToPay -= priceVariable;
                tbPrice.Text = PriceToPay.ToString();
            }
        }

        private void cbVolant_CheckedChanged(object sender, EventArgs e)
        {
            CheckCheckBox(cbVolant, volant);
        }
        
        private void cbWheel_CheckedChanged(object sender, EventArgs e)
        {
            CheckCheckBox(cbWheel, wheel);
        }

        private void cbDirection_CheckedChanged(object sender, EventArgs e)
        {
            CheckCheckBox(cbDirection, direction);
        }

        private void cbBrakes_CheckedChanged(object sender, EventArgs e)
        {
            CheckCheckBox(cbBrakes, brakes);
        }

        private void cbAbs_CheckedChanged(object sender, EventArgs e)
        {
            CheckCheckBox(cbAbs, abs);
        }

        private void btnCheckall_Click(object sender, EventArgs e)
        {
            foreach(CheckBox c in gbOptions.Controls)
            {
                c.Checked = true;
            }
            PriceToPay = fee + wheel + volant + direction + abs + brakes;
            tbPrice.Text = PriceToPay.ToString();
        }

        private void btnAucunoptions_Click(object sender, EventArgs e)
        {
            foreach (CheckBox c in gbOptions.Controls)
            {
                c.Checked = false;
            }
            PriceToPay = fee;
            tbPrice.Text = PriceToPay.ToString();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
