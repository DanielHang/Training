namespace Calculator
{
	partial class Form1
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.one = new System.Windows.Forms.Button();
			this.two = new System.Windows.Forms.Button();
			this.three = new System.Windows.Forms.Button();
			this.four = new System.Windows.Forms.Button();
			this.five = new System.Windows.Forms.Button();
			this.six = new System.Windows.Forms.Button();
			this.seven = new System.Windows.Forms.Button();
			this.eight = new System.Windows.Forms.Button();
			this.nine = new System.Windows.Forms.Button();
			this.zero = new System.Windows.Forms.Button();
			this.decimalPoint = new System.Windows.Forms.Button();
			this.equals = new System.Windows.Forms.Button();
			this.plus = new System.Windows.Forms.Button();
			this.minus = new System.Windows.Forms.Button();
			this.multiply = new System.Windows.Forms.Button();
			this.divide = new System.Windows.Forms.Button();
			this.clearEverything = new System.Windows.Forms.Button();
			this.clear = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.White;
			this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.textBox1.Location = new System.Drawing.Point(12, 24);
			this.textBox1.Name = "textBox1";
			this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.textBox1.Size = new System.Drawing.Size(271, 22);
			this.textBox1.TabIndex = 0;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// one
			// 
			this.one.AccessibleName = "";
			this.one.Location = new System.Drawing.Point(13, 255);
			this.one.Name = "one";
			this.one.Size = new System.Drawing.Size(63, 56);
			this.one.TabIndex = 1;
			this.one.Text = "1";
			this.one.UseVisualStyleBackColor = true;
			this.one.Click += new System.EventHandler(this.one_Click);
			// 
			// two
			// 
			this.two.Location = new System.Drawing.Point(82, 255);
			this.two.Name = "two";
			this.two.Size = new System.Drawing.Size(63, 56);
			this.two.TabIndex = 2;
			this.two.Text = "2";
			this.two.UseVisualStyleBackColor = true;
			this.two.Click += new System.EventHandler(this.two_Click);
			// 
			// three
			// 
			this.three.Location = new System.Drawing.Point(151, 255);
			this.three.Name = "three";
			this.three.Size = new System.Drawing.Size(63, 56);
			this.three.TabIndex = 3;
			this.three.Text = "3";
			this.three.UseVisualStyleBackColor = true;
			this.three.Click += new System.EventHandler(this.three_Click);
			// 
			// four
			// 
			this.four.Location = new System.Drawing.Point(13, 193);
			this.four.Name = "four";
			this.four.Size = new System.Drawing.Size(63, 56);
			this.four.TabIndex = 4;
			this.four.Text = "4";
			this.four.UseVisualStyleBackColor = true;
			this.four.Click += new System.EventHandler(this.four_Click);
			// 
			// five
			// 
			this.five.Location = new System.Drawing.Point(82, 193);
			this.five.Name = "five";
			this.five.Size = new System.Drawing.Size(63, 56);
			this.five.TabIndex = 5;
			this.five.Text = "5";
			this.five.UseVisualStyleBackColor = true;
			this.five.Click += new System.EventHandler(this.five_Click);
			// 
			// six
			// 
			this.six.Location = new System.Drawing.Point(151, 193);
			this.six.Name = "six";
			this.six.Size = new System.Drawing.Size(63, 56);
			this.six.TabIndex = 6;
			this.six.Text = "6";
			this.six.UseVisualStyleBackColor = true;
			this.six.Click += new System.EventHandler(this.six_Click);
			// 
			// seven
			// 
			this.seven.Location = new System.Drawing.Point(13, 131);
			this.seven.Name = "seven";
			this.seven.Size = new System.Drawing.Size(63, 56);
			this.seven.TabIndex = 7;
			this.seven.Text = "7";
			this.seven.UseVisualStyleBackColor = true;
			this.seven.Click += new System.EventHandler(this.seven_Click);
			// 
			// eight
			// 
			this.eight.Location = new System.Drawing.Point(82, 131);
			this.eight.Name = "eight";
			this.eight.Size = new System.Drawing.Size(63, 56);
			this.eight.TabIndex = 8;
			this.eight.Text = "8";
			this.eight.UseVisualStyleBackColor = true;
			this.eight.Click += new System.EventHandler(this.eight_Click);
			// 
			// nine
			// 
			this.nine.Location = new System.Drawing.Point(151, 131);
			this.nine.Name = "nine";
			this.nine.Size = new System.Drawing.Size(63, 56);
			this.nine.TabIndex = 9;
			this.nine.Text = "9";
			this.nine.UseVisualStyleBackColor = true;
			this.nine.Click += new System.EventHandler(this.nine_Click);
			// 
			// zero
			// 
			this.zero.Location = new System.Drawing.Point(13, 317);
			this.zero.Name = "zero";
			this.zero.Size = new System.Drawing.Size(63, 56);
			this.zero.TabIndex = 10;
			this.zero.Text = "0";
			this.zero.UseVisualStyleBackColor = true;
			this.zero.Click += new System.EventHandler(this.zero_Click);
			// 
			// decimalPoint
			// 
			this.decimalPoint.Location = new System.Drawing.Point(82, 317);
			this.decimalPoint.Name = "decimalPoint";
			this.decimalPoint.Size = new System.Drawing.Size(63, 56);
			this.decimalPoint.TabIndex = 12;
			this.decimalPoint.Text = ".";
			this.decimalPoint.UseVisualStyleBackColor = true;
			this.decimalPoint.Click += new System.EventHandler(this.decimalPoint_Click);
			// 
			// equals
			// 
			this.equals.Location = new System.Drawing.Point(151, 317);
			this.equals.Name = "equals";
			this.equals.Size = new System.Drawing.Size(132, 56);
			this.equals.TabIndex = 13;
			this.equals.Text = "=";
			this.equals.UseVisualStyleBackColor = true;
			this.equals.Click += new System.EventHandler(this.equals_Click);
			// 
			// plus
			// 
			this.plus.Location = new System.Drawing.Point(220, 255);
			this.plus.Name = "plus";
			this.plus.Size = new System.Drawing.Size(63, 56);
			this.plus.TabIndex = 14;
			this.plus.Text = "+";
			this.plus.UseVisualStyleBackColor = true;
			this.plus.Click += new System.EventHandler(this.plus_Click);
			// 
			// minus
			// 
			this.minus.Location = new System.Drawing.Point(220, 193);
			this.minus.Name = "minus";
			this.minus.Size = new System.Drawing.Size(63, 56);
			this.minus.TabIndex = 15;
			this.minus.Text = "-";
			this.minus.UseVisualStyleBackColor = true;
			this.minus.Click += new System.EventHandler(this.minus_Click);
			// 
			// multiply
			// 
			this.multiply.Location = new System.Drawing.Point(220, 131);
			this.multiply.Name = "multiply";
			this.multiply.Size = new System.Drawing.Size(63, 56);
			this.multiply.TabIndex = 16;
			this.multiply.Text = "x";
			this.multiply.UseVisualStyleBackColor = true;
			this.multiply.Click += new System.EventHandler(this.multiply_Click);
			// 
			// divide
			// 
			this.divide.Location = new System.Drawing.Point(220, 69);
			this.divide.Name = "divide";
			this.divide.Size = new System.Drawing.Size(63, 56);
			this.divide.TabIndex = 17;
			this.divide.Text = "/";
			this.divide.UseVisualStyleBackColor = true;
			this.divide.Click += new System.EventHandler(this.divide_Click);
			// 
			// clearEverything
			// 
			this.clearEverything.Location = new System.Drawing.Point(12, 69);
			this.clearEverything.Name = "clearEverything";
			this.clearEverything.Size = new System.Drawing.Size(133, 56);
			this.clearEverything.TabIndex = 18;
			this.clearEverything.Text = "CE";
			this.clearEverything.UseVisualStyleBackColor = true;
			this.clearEverything.Click += new System.EventHandler(this.clearEverything_Click);
			// 
			// clear
			// 
			this.clear.Location = new System.Drawing.Point(151, 69);
			this.clear.Name = "clear";
			this.clear.Size = new System.Drawing.Size(63, 56);
			this.clear.TabIndex = 19;
			this.clear.Text = "C";
			this.clear.UseVisualStyleBackColor = true;
			this.clear.Click += new System.EventHandler(this.clear_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(301, 392);
			this.Controls.Add(this.clear);
			this.Controls.Add(this.clearEverything);
			this.Controls.Add(this.divide);
			this.Controls.Add(this.multiply);
			this.Controls.Add(this.minus);
			this.Controls.Add(this.plus);
			this.Controls.Add(this.equals);
			this.Controls.Add(this.decimalPoint);
			this.Controls.Add(this.zero);
			this.Controls.Add(this.nine);
			this.Controls.Add(this.eight);
			this.Controls.Add(this.seven);
			this.Controls.Add(this.six);
			this.Controls.Add(this.five);
			this.Controls.Add(this.four);
			this.Controls.Add(this.three);
			this.Controls.Add(this.two);
			this.Controls.Add(this.one);
			this.Controls.Add(this.textBox1);
			this.Name = "Form1";
			this.Text = "Calculator";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button one;
		private System.Windows.Forms.Button two;
		private System.Windows.Forms.Button three;
		private System.Windows.Forms.Button four;
		private System.Windows.Forms.Button five;
		private System.Windows.Forms.Button six;
		private System.Windows.Forms.Button seven;
		private System.Windows.Forms.Button eight;
		private System.Windows.Forms.Button nine;
		private System.Windows.Forms.Button zero;
		private System.Windows.Forms.Button decimalPoint;
		private System.Windows.Forms.Button equals;
		private System.Windows.Forms.Button plus;
		private System.Windows.Forms.Button minus;
		private System.Windows.Forms.Button multiply;
		private System.Windows.Forms.Button divide;
		private System.Windows.Forms.Button clearEverything;
		private System.Windows.Forms.Button clear;
	}
}

