namespace GalacticRentalsFormsApplication
{
	partial class formMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
			System.Windows.Forms.Label clientIdLabel;
			System.Windows.Forms.Label nameLabel;
			System.Windows.Forms.Label surnameLabel;
			System.Windows.Forms.Label phoneLabel;
			System.Windows.Forms.Label emailLabel;
			System.Windows.Forms.Label addressLine1Label;
			System.Windows.Forms.Label addressLine2Label;
			System.Windows.Forms.Label addressCityLabel;
			System.Windows.Forms.Label addressPostCodeLabel;
			System.Windows.Forms.Label activeLabel;
			System.Windows.Forms.Label titleLabel;
			this.galacticRentalsDataSet = new GalacticRentalsFormsApplication.GalacticRentalsDataSet();
			this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.clientsTableAdapter = new GalacticRentalsFormsApplication.GalacticRentalsDataSetTableAdapters.ClientsTableAdapter();
			this.tableAdapterManager = new GalacticRentalsFormsApplication.GalacticRentalsDataSetTableAdapters.TableAdapterManager();
			this.clientsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
			this.clientsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.clientIdTextBox = new System.Windows.Forms.TextBox();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.surnameTextBox = new System.Windows.Forms.TextBox();
			this.phoneTextBox = new System.Windows.Forms.TextBox();
			this.emailTextBox = new System.Windows.Forms.TextBox();
			this.addressLine1TextBox = new System.Windows.Forms.TextBox();
			this.addressLine2TextBox = new System.Windows.Forms.TextBox();
			this.addressCityTextBox = new System.Windows.Forms.TextBox();
			this.addressPostCodeTextBox = new System.Windows.Forms.TextBox();
			this.activeCheckBox = new System.Windows.Forms.CheckBox();
			this.titleTextBox = new System.Windows.Forms.TextBox();
			clientIdLabel = new System.Windows.Forms.Label();
			nameLabel = new System.Windows.Forms.Label();
			surnameLabel = new System.Windows.Forms.Label();
			phoneLabel = new System.Windows.Forms.Label();
			emailLabel = new System.Windows.Forms.Label();
			addressLine1Label = new System.Windows.Forms.Label();
			addressLine2Label = new System.Windows.Forms.Label();
			addressCityLabel = new System.Windows.Forms.Label();
			addressPostCodeLabel = new System.Windows.Forms.Label();
			activeLabel = new System.Windows.Forms.Label();
			titleLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.galacticRentalsDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.clientsBindingNavigator)).BeginInit();
			this.clientsBindingNavigator.SuspendLayout();
			this.SuspendLayout();
			// 
			// galacticRentalsDataSet
			// 
			this.galacticRentalsDataSet.DataSetName = "GalacticRentalsDataSet";
			this.galacticRentalsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// clientsBindingSource
			// 
			this.clientsBindingSource.DataMember = "Clients";
			this.clientsBindingSource.DataSource = this.galacticRentalsDataSet;
			// 
			// clientsTableAdapter
			// 
			this.clientsTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.ChargesTableAdapter = null;
			this.tableAdapterManager.ClientsTableAdapter = this.clientsTableAdapter;
			this.tableAdapterManager.DVDItemTableAdapter = null;
			this.tableAdapterManager.MovieTableAdapter = null;
			this.tableAdapterManager.RentalsTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = GalacticRentalsFormsApplication.GalacticRentalsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// clientsBindingNavigator
			// 
			this.clientsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.clientsBindingNavigator.BindingSource = this.clientsBindingSource;
			this.clientsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.clientsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.clientsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.clientsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.clientsBindingNavigatorSaveItem});
			this.clientsBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.clientsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.clientsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.clientsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.clientsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.clientsBindingNavigator.Name = "clientsBindingNavigator";
			this.clientsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.clientsBindingNavigator.Size = new System.Drawing.Size(774, 27);
			this.clientsBindingNavigator.TabIndex = 0;
			this.clientsBindingNavigator.Text = "bindingNavigator1";
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 22);
			this.bindingNavigatorMoveFirstItem.Text = "Move first";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 22);
			this.bindingNavigatorMovePreviousItem.Text = "Move previous";
			// 
			// bindingNavigatorSeparator
			// 
			this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorPositionItem
			// 
			this.bindingNavigatorPositionItem.AccessibleName = "Position";
			this.bindingNavigatorPositionItem.AutoSize = false;
			this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "Current position";
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 20);
			this.bindingNavigatorCountItem.Text = "of {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
			this.bindingNavigatorMoveNextItem.Text = "Move next";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
			this.bindingNavigatorMoveLastItem.Text = "Move last";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
			// 
			// bindingNavigatorAddNewItem
			// 
			this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
			this.bindingNavigatorAddNewItem.Text = "Add new";
			// 
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
			this.bindingNavigatorDeleteItem.Text = "Delete";
			// 
			// clientsBindingNavigatorSaveItem
			// 
			this.clientsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.clientsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("clientsBindingNavigatorSaveItem.Image")));
			this.clientsBindingNavigatorSaveItem.Name = "clientsBindingNavigatorSaveItem";
			this.clientsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
			this.clientsBindingNavigatorSaveItem.Text = "Save Data";
			this.clientsBindingNavigatorSaveItem.Click += new System.EventHandler(this.clientsBindingNavigatorSaveItem_Click);
			// 
			// clientIdLabel
			// 
			clientIdLabel.AutoSize = true;
			clientIdLabel.Location = new System.Drawing.Point(207, 83);
			clientIdLabel.Name = "clientIdLabel";
			clientIdLabel.Size = new System.Drawing.Size(60, 17);
			clientIdLabel.TabIndex = 1;
			clientIdLabel.Text = "client Id:";
			// 
			// clientIdTextBox
			// 
			this.clientIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "clientId", true));
			this.clientIdTextBox.Location = new System.Drawing.Point(345, 80);
			this.clientIdTextBox.Name = "clientIdTextBox";
			this.clientIdTextBox.Size = new System.Drawing.Size(104, 22);
			this.clientIdTextBox.TabIndex = 2;
			// 
			// nameLabel
			// 
			nameLabel.AutoSize = true;
			nameLabel.Location = new System.Drawing.Point(207, 111);
			nameLabel.Name = "nameLabel";
			nameLabel.Size = new System.Drawing.Size(47, 17);
			nameLabel.TabIndex = 3;
			nameLabel.Text = "name:";
			// 
			// nameTextBox
			// 
			this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "name", true));
			this.nameTextBox.Location = new System.Drawing.Point(345, 108);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(104, 22);
			this.nameTextBox.TabIndex = 4;
			// 
			// surnameLabel
			// 
			surnameLabel.AutoSize = true;
			surnameLabel.Location = new System.Drawing.Point(207, 139);
			surnameLabel.Name = "surnameLabel";
			surnameLabel.Size = new System.Drawing.Size(67, 17);
			surnameLabel.TabIndex = 5;
			surnameLabel.Text = "surname:";
			// 
			// surnameTextBox
			// 
			this.surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "surname", true));
			this.surnameTextBox.Location = new System.Drawing.Point(345, 136);
			this.surnameTextBox.Name = "surnameTextBox";
			this.surnameTextBox.Size = new System.Drawing.Size(104, 22);
			this.surnameTextBox.TabIndex = 6;
			// 
			// phoneLabel
			// 
			phoneLabel.AutoSize = true;
			phoneLabel.Location = new System.Drawing.Point(207, 167);
			phoneLabel.Name = "phoneLabel";
			phoneLabel.Size = new System.Drawing.Size(52, 17);
			phoneLabel.TabIndex = 7;
			phoneLabel.Text = "phone:";
			// 
			// phoneTextBox
			// 
			this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "phone", true));
			this.phoneTextBox.Location = new System.Drawing.Point(345, 164);
			this.phoneTextBox.Name = "phoneTextBox";
			this.phoneTextBox.Size = new System.Drawing.Size(104, 22);
			this.phoneTextBox.TabIndex = 8;
			// 
			// emailLabel
			// 
			emailLabel.AutoSize = true;
			emailLabel.Location = new System.Drawing.Point(207, 195);
			emailLabel.Name = "emailLabel";
			emailLabel.Size = new System.Drawing.Size(45, 17);
			emailLabel.TabIndex = 9;
			emailLabel.Text = "email:";
			// 
			// emailTextBox
			// 
			this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "email", true));
			this.emailTextBox.Location = new System.Drawing.Point(345, 192);
			this.emailTextBox.Name = "emailTextBox";
			this.emailTextBox.Size = new System.Drawing.Size(104, 22);
			this.emailTextBox.TabIndex = 10;
			// 
			// addressLine1Label
			// 
			addressLine1Label.AutoSize = true;
			addressLine1Label.Location = new System.Drawing.Point(207, 223);
			addressLine1Label.Name = "addressLine1Label";
			addressLine1Label.Size = new System.Drawing.Size(102, 17);
			addressLine1Label.TabIndex = 11;
			addressLine1Label.Text = "address Line1:";
			// 
			// addressLine1TextBox
			// 
			this.addressLine1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "addressLine1", true));
			this.addressLine1TextBox.Location = new System.Drawing.Point(345, 220);
			this.addressLine1TextBox.Name = "addressLine1TextBox";
			this.addressLine1TextBox.Size = new System.Drawing.Size(104, 22);
			this.addressLine1TextBox.TabIndex = 12;
			// 
			// addressLine2Label
			// 
			addressLine2Label.AutoSize = true;
			addressLine2Label.Location = new System.Drawing.Point(207, 251);
			addressLine2Label.Name = "addressLine2Label";
			addressLine2Label.Size = new System.Drawing.Size(102, 17);
			addressLine2Label.TabIndex = 13;
			addressLine2Label.Text = "address Line2:";
			// 
			// addressLine2TextBox
			// 
			this.addressLine2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "addressLine2", true));
			this.addressLine2TextBox.Location = new System.Drawing.Point(345, 248);
			this.addressLine2TextBox.Name = "addressLine2TextBox";
			this.addressLine2TextBox.Size = new System.Drawing.Size(104, 22);
			this.addressLine2TextBox.TabIndex = 14;
			// 
			// addressCityLabel
			// 
			addressCityLabel.AutoSize = true;
			addressCityLabel.Location = new System.Drawing.Point(207, 279);
			addressCityLabel.Name = "addressCityLabel";
			addressCityLabel.Size = new System.Drawing.Size(90, 17);
			addressCityLabel.TabIndex = 15;
			addressCityLabel.Text = "address City:";
			// 
			// addressCityTextBox
			// 
			this.addressCityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "addressCity", true));
			this.addressCityTextBox.Location = new System.Drawing.Point(345, 276);
			this.addressCityTextBox.Name = "addressCityTextBox";
			this.addressCityTextBox.Size = new System.Drawing.Size(104, 22);
			this.addressCityTextBox.TabIndex = 16;
			// 
			// addressPostCodeLabel
			// 
			addressPostCodeLabel.AutoSize = true;
			addressPostCodeLabel.Location = new System.Drawing.Point(207, 307);
			addressPostCodeLabel.Name = "addressPostCodeLabel";
			addressPostCodeLabel.Size = new System.Drawing.Size(132, 17);
			addressPostCodeLabel.TabIndex = 17;
			addressPostCodeLabel.Text = "address Post Code:";
			// 
			// addressPostCodeTextBox
			// 
			this.addressPostCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "addressPostCode", true));
			this.addressPostCodeTextBox.Location = new System.Drawing.Point(345, 304);
			this.addressPostCodeTextBox.Name = "addressPostCodeTextBox";
			this.addressPostCodeTextBox.Size = new System.Drawing.Size(104, 22);
			this.addressPostCodeTextBox.TabIndex = 18;
			// 
			// activeLabel
			// 
			activeLabel.AutoSize = true;
			activeLabel.Location = new System.Drawing.Point(207, 337);
			activeLabel.Name = "activeLabel";
			activeLabel.Size = new System.Drawing.Size(49, 17);
			activeLabel.TabIndex = 19;
			activeLabel.Text = "active:";
			// 
			// activeCheckBox
			// 
			this.activeCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.clientsBindingSource, "active", true));
			this.activeCheckBox.Location = new System.Drawing.Point(345, 332);
			this.activeCheckBox.Name = "activeCheckBox";
			this.activeCheckBox.Size = new System.Drawing.Size(104, 24);
			this.activeCheckBox.TabIndex = 20;
			this.activeCheckBox.UseVisualStyleBackColor = true;
			// 
			// titleLabel
			// 
			titleLabel.AutoSize = true;
			titleLabel.Location = new System.Drawing.Point(207, 365);
			titleLabel.Name = "titleLabel";
			titleLabel.Size = new System.Drawing.Size(34, 17);
			titleLabel.TabIndex = 21;
			titleLabel.Text = "title:";
			// 
			// titleTextBox
			// 
			this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "title", true));
			this.titleTextBox.Location = new System.Drawing.Point(345, 362);
			this.titleTextBox.Name = "titleTextBox";
			this.titleTextBox.Size = new System.Drawing.Size(104, 22);
			this.titleTextBox.TabIndex = 22;
			// 
			// formMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(774, 517);
			this.Controls.Add(clientIdLabel);
			this.Controls.Add(this.clientIdTextBox);
			this.Controls.Add(nameLabel);
			this.Controls.Add(this.nameTextBox);
			this.Controls.Add(surnameLabel);
			this.Controls.Add(this.surnameTextBox);
			this.Controls.Add(phoneLabel);
			this.Controls.Add(this.phoneTextBox);
			this.Controls.Add(emailLabel);
			this.Controls.Add(this.emailTextBox);
			this.Controls.Add(addressLine1Label);
			this.Controls.Add(this.addressLine1TextBox);
			this.Controls.Add(addressLine2Label);
			this.Controls.Add(this.addressLine2TextBox);
			this.Controls.Add(addressCityLabel);
			this.Controls.Add(this.addressCityTextBox);
			this.Controls.Add(addressPostCodeLabel);
			this.Controls.Add(this.addressPostCodeTextBox);
			this.Controls.Add(activeLabel);
			this.Controls.Add(this.activeCheckBox);
			this.Controls.Add(titleLabel);
			this.Controls.Add(this.titleTextBox);
			this.Controls.Add(this.clientsBindingNavigator);
			this.Name = "formMain";
			this.Text = "Clients";
			this.Load += new System.EventHandler(this.formMain_Load);
			((System.ComponentModel.ISupportInitialize)(this.galacticRentalsDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.clientsBindingNavigator)).EndInit();
			this.clientsBindingNavigator.ResumeLayout(false);
			this.clientsBindingNavigator.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private GalacticRentalsDataSet galacticRentalsDataSet;
		private System.Windows.Forms.BindingSource clientsBindingSource;
		private GalacticRentalsDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
		private GalacticRentalsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator clientsBindingNavigator;
		private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private System.Windows.Forms.ToolStripButton clientsBindingNavigatorSaveItem;
		private System.Windows.Forms.TextBox clientIdTextBox;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.TextBox surnameTextBox;
		private System.Windows.Forms.TextBox phoneTextBox;
		private System.Windows.Forms.TextBox emailTextBox;
		private System.Windows.Forms.TextBox addressLine1TextBox;
		private System.Windows.Forms.TextBox addressLine2TextBox;
		private System.Windows.Forms.TextBox addressCityTextBox;
		private System.Windows.Forms.TextBox addressPostCodeTextBox;
		private System.Windows.Forms.CheckBox activeCheckBox;
		private System.Windows.Forms.TextBox titleTextBox;
	}
}

