using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game1
{
    public partial class Form1 : Form
    {
        
        char who = 'o';
        int turnCounter = 0;
        public Form1()
        {
            InitializeComponent();
            
                        
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Guna2Button bt = sender as Guna2Button;
            
            if(bt != null )
            {
                if(who == 'o') bt.Text = "O"; else bt.Text = "X";
                if (who == 'o') who = 'x'; else who = 'o';
                bt.Enabled = false;
                turnCounter++;
                bt.ForeColor = Color.Red;
                bt.BackColor = Color.Red;
                CheckTheWinner(bt);
            }
            
        }

        private void ChangeBackColor(Guna2Button button1, Guna2Button button2, Guna2Button button3)
        {
            button1.BackColor = Color.Green;
            button2.BackColor = Color.Green;
            button3.BackColor = Color.Green;
        }

        // Horizantal
        private bool HLine1()
        {
            if (btnA.Text == btnB.Text && btnB.Text == btnC.Text)
            {
                ChangeBackColor(btnA, btnB, btnC);
                return true;
            }
            return false;
        }
        private bool HLine2()
        {
            if (btnD.Text == btnE.Text && btnE.Text == btnF.Text)
            {
                ChangeBackColor(btnD, btnE, btnF);
                return true;
            }
            return false;
        }
        private bool HLine3()
        {
            if (btnG.Text == btnH.Text && btnH.Text == btnI.Text)
            {
                ChangeBackColor(btnG, btnH, btnI);
                return true;
            }
            return false;
        }
        // Vertical
        private bool VLine1()
        {
            if (btnA.Text == btnD.Text && btnD.Text == btnG.Text)
            {
                ChangeBackColor(btnA, btnD, btnG);
                return true;
            }
            return false;
        }
        private bool VLine2()
        {
            if (btnB.Text == btnE.Text && btnE.Text == btnH.Text)
            {
                ChangeBackColor(btnB, btnE, btnH);
                return true;
            }
            return false;
        }
        private bool VLine3()
        {
            if (btnC.Text == btnF.Text && btnF.Text == btnI.Text)
            {
                ChangeBackColor(btnC, btnF, btnI);
                return true;
            }
            return false;
        }
        // Diagonal
        private bool DLine1()
        {
            if (btnA.Text == btnE.Text && btnE.Text == btnI.Text)
            {
                ChangeBackColor(btnA, btnE, btnI);
                return true;
            }
            return false;
        }
        private bool DLine2()
        {
            if (btnG.Text == btnE.Text && btnE.Text == btnC.Text)
            {
                ChangeBackColor(btnG, btnE, btnC);
                return true;
            }
            return false;
        }

        private void CheckTheWinner(Guna2Button bt)
        {
            bool isWinner = false;


            switch (bt.Name)
            {
                case "btnA":
                    if(HLine1() || VLine1() || DLine1()) isWinner = true;
                    break;
                case "btn.B":
                    if(HLine1() || VLine2()) isWinner = true;
                    break;
                case "btnC":
                    if(HLine1() || VLine3() || DLine2()) isWinner = true;
                    break;
                case "btnD":

                    break;
            }
        }
    }
}
