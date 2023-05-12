using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PurchaseProduct
{
    public partial class purchaseProduct : Form
    {
        public purchaseProduct()
        {
            InitializeComponent();
            lblResult.ForeColor = Color.Blue;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            DialogResult val = MessageBox.Show("1- To purchase the complete software. Press YES.\n2- For 30 days Trial use. Press No.\n3- To Cancel the Order. Press Cancel.","Software lifetime", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            string text = String.Empty;
            Color color = Color.Blue;
            
            switch (val)
            {
                case DialogResult.Cancel:
                    text = "Congratulations, you have purchased the complete software for unlimited time.";
                    color = Color.Red;
                    break;
                case DialogResult.Yes:
                    text = "you can use this software for free for 30 days.";
                    break;
                case DialogResult.No:
                    text = "you cancelled the order";
                    break;
            }
            lblResult.Text = text;
            lblResult.ForeColor = color;
        }
    }
}
