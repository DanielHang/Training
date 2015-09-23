using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GalacticDVDApplication
{
	public partial class Form1 : Form
	{
		private SqlConnection con;
		private SqlCommand cmd;
		private SqlDataAdapter da;
		private DataTable dt;
		public Form1()
		{
			InitializeComponent();
			ConnectDB();
		}

		public void ConnectDB()
		{
			con=new SqlConnection(@"Data Source=TALSMONKEY\SQLEXPRESS;Initial Catalog=GalacticRentals;Integrated Security=True");
			con.Open();
			cmd = new SqlCommand("SELECT * FROM Clients");
			cmd.Connection = con;
			da = new SqlDataAdapter(cmd);
			dt = new DataTable();
			da.Fill(dt);
			textBox1.Text = dt.Rows[0]["name"].ToString().Trim();
			textBox2.Text = dt.Rows[0]["surname"].ToString().Trim();
			textBox3.Text = dt.Rows[0]["phone"].ToString().Trim();
			textBox4.Text = dt.Rows[0]["email"].ToString().Trim();

		}
	}
}
