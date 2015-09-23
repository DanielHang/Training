using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GalacticRentalsFormsApplication
{
	public partial class formMain : Form
	{
		public formMain()
		{
			InitializeComponent();
		}

		private void clientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.clientsBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.galacticRentalsDataSet);

		}

		private void formMain_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'galacticRentalsDataSet.Clients' table. You can move, or remove it, as needed.
			this.clientsTableAdapter.Fill(this.galacticRentalsDataSet.Clients);

		}
	}
}
