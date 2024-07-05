using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winformsWebService
{
	public partial class Form1 : Form
	{
		
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string url = "https://localhost:44309/MonWebService.asmx/CredataTable";
			
		}
	}
}
