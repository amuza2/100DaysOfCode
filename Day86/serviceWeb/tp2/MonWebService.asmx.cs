using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace tp2
{
	/// <summary>
	/// Summary description for MonWebService
	/// </summary>
	[WebService(Namespace = "http://tempuri.org/")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[System.ComponentModel.ToolboxItem(false)]
	// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
	// [System.Web.Script.Services.ScriptService]
	public class MonWebService : System.Web.Services.WebService
	{

		[WebMethod]
		public string HelloWorld()
		{
			return "Hello World";
		}
		[WebMethod]
		public DataTable CredataTable(string tableName)
		{
			DataTable dataTable = new DataTable();
			string conString = "Data Source=.;Initial Catalog=cenimaDatabase;Integrated Security=True;Encrypt=True";
			using (SqlConnection sqlConnection = new SqlConnection(conString))
			{
				try
				{
					sqlConnection.Open();
					string query = "select * from " + tableName;
					using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
					{
						using (SqlDataAdapter adapter = new SqlDataAdapter())
						{
							adapter.Fill(dataTable);
						}
					}
				}
				catch (Exception ex)
				{
                    Console.WriteLine("error", ex.Message);
                }
				finally
				{
					sqlConnection.Close();
				}
			}
			return dataTable;


		}
	}
}
