namespace DateTimeApp
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void showbtn_Click(object sender, EventArgs e)
        {
            label6.Text = dateTimePicker.Value.ToString("dd MM, yyyy: mm ");
            label7.Text = dateTimePicker.Value.ToShortDateString();
            label8.Text = dateTimePicker.Value.ToLongDateString();
            label9.Text = dateTimePicker.Value.ToShortTimeString();
            label10.Text = dateTimePicker.Value.ToLongTimeString();
        }
    }
}