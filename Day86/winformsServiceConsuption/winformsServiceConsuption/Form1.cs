using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winformsServiceConsuption
{
	public partial class Form1 : Form
	{
		ServiceReference1.WebService1SoapClient service = new ServiceReference1.WebService1SoapClient();
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private async void button1_Click(object sender, EventArgs e)
		{
			try
			{
				DataTable dt = await service.CredataTableAsync("realisator");
				dataGridView1.DataSource = dt;

			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message, "error");
			}
		}
	}
}
