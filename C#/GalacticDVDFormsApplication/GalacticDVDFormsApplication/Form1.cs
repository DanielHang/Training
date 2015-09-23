using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GalacticDVDFormsApplication
{
	public partial class Form1 : Form
	{
		private SqlDbConnect con;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			comboBox1.Items.Clear();
			con = new SqlDbConnect();
			con.SqlQuery("SELECT * FROM Clients");
			foreach (DataRow dr in con.QueryEx().Rows)
			{
				comboBox1.Items.Add(dr[1].ToString());
			}
		}
	}
}
