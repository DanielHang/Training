using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GalacticRenatalsADOApplication
{
	public partial class Form1 : Form
	{
		GalacticRentalsEntities grEntity;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			grEntity = new GalacticRentalsEntities();
			comboBox1.DataSource = grEntity.Clients;
			Console.WriteLine(grEntity.Clients);
			comboBox1.DisplayMember = "name";
		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			grEntity.Dispose();
		}

	}
}
