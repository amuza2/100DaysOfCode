namespace WinFormDemo;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    void loginFrame()
    {
        string login = UserIDTextBox.Text.Trim();
        string password = PasswordTextBox.Text.Trim();
        if (login == "moh" && password == "123")
        {
            Home HomeWindow = new Home();
            this.Hide();
            HomeWindow.Show();
        }
        else
        {
            MessageBox.Show("Wrong!", "Error");
        }
    }
    void ClearTextBox()
    {
        UserIDTextBox.Text = "";
        PasswordTextBox.Text = "";
    }
    private void button1_Click(object sender, EventArgs e)
    {
        loginFrame();
    }

    private void Reset_Click(object sender, EventArgs e)
    {
        ClearTextBox();
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (e.CloseReason == CloseReason.UserClosing)
        {
            Application.Exit();
        }
    }

    private void PasswordTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if(e.KeyChar == (char)Keys.Enter)
        {
            loginFrame();
        }
        if(e.KeyChar == (char)Keys.Escape)
        {
            ClearTextBox();
        }
    }
}