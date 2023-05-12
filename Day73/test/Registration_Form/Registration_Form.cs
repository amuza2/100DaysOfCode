using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration_Form
{
    public partial class Registration_Form : Form
    {
        public Registration_Form()
        {
            InitializeComponent();
        }
        
        public string RadioButtonValue = String.Empty;
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < gb1.Controls.Count; i++) 
            {
                Control control = gb1.Controls[i];
                if (control is RadioButton radiobutton && radiobutton.Checked)
                {
                    RadioButtonValue = radiobutton.Text;
                    break;
                }
            }
            MessageBox.Show(RadioButtonValue, "Name");


        }



    }
}
