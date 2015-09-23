using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
	public partial class Form1 : Form
	{
		/* Declare Variabnles*/
		String input = string.Empty;
		String operand1 = string.Empty;
		String operand2 = string.Empty;
		char operation;
		double result = 0.0;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void one_Click(object sender, EventArgs e)
		{
			this.textBox1.Text = "";
			input += "1";
			this.textBox1.Text += input;
		}

		private void two_Click(object sender, EventArgs e)
		{
			this.textBox1.Text = "";
			input += "2";
			this.textBox1.Text += input;
		}

		private void three_Click(object sender, EventArgs e)
		{
			this.textBox1.Text = "";
			input += "3";
			this.textBox1.Text += input;
		}

		private void four_Click(object sender, EventArgs e)
		{
			this.textBox1.Text = "";
			input += "4";
			this.textBox1.Text += input;
		}

		private void five_Click(object sender, EventArgs e)
		{
			this.textBox1.Text = "";
			input += "5";
			this.textBox1.Text += input;
		}

		private void six_Click(object sender, EventArgs e)
		{
			this.textBox1.Text = "";
			input += "6";
			this.textBox1.Text += input;
		}

		private void seven_Click(object sender, EventArgs e)
		{
			this.textBox1.Text = "";
			input += "7";
			this.textBox1.Text += input;
		}

		private void eight_Click(object sender, EventArgs e)
		{
			this.textBox1.Text = "";
			input += "8";
			this.textBox1.Text += input;
		}

		private void nine_Click(object sender, EventArgs e)
		{
			this.textBox1.Text = "";
			input += "9";
			this.textBox1.Text += input;
		}

		private void zero_Click(object sender, EventArgs e)
		{
			this.textBox1.Text = "";
			input += "0";
			this.textBox1.Text += input;
		}

		private void decimalPoint_Click(object sender, EventArgs e)
		{
			this.textBox1.Text = "";
			input += ",";
			this.textBox1.Text += input;
		}

		private void equals_Click(object sender, EventArgs e)
		{
			operand2 = input;
			double num1, num2;

			if ((operand1 != string.Empty) && (operand2 != string.Empty))
			{
				num1 = Convert.ToDouble(operand1);
				num2 = Convert.ToDouble(operand2);

				/*Clear old data before calc*/
				this.textBox1.Text = "";
				this.input = string.Empty;
				this.operand1 = string.Empty;
				this.operand2 = string.Empty;

				if (operation == '+')
				{
					result = num1 + num2;
					textBox1.Text = result.ToString();
				}
				else if (operation == '-')
				{
					result = num1 - num2;
					textBox1.Text = result.ToString();
				}
				else if (operation == '*')
				{
					result = num1 * num2;
					textBox1.Text = result.ToString();
				}
				else if (operation == '/')
				{
					if (num2 != 0)
					{
						result = num1 / num2;
						textBox1.Text = result.ToString();
					}
					else
					{
						textBox1.Text = "DIV/Zero!";
					}
				}
			}
		}

		private void plus_Click(object sender, EventArgs e)
		{
			if (input == string.Empty && result != 0)
			{
				operand1 = result.ToString();
				operation = '+';
				input = String.Empty;
			}
			else
			{
				operand1 = input;
				operation = '+';
				input = String.Empty;
			}
		}

		private void minus_Click(object sender, EventArgs e)
		{
			if (input == string.Empty && result != 0)
			{
				operand1 = result.ToString();
				operation = '-';
				input = String.Empty;
			}
			else
			{
				operand1 = input;
				operation = '-';
				input = String.Empty;
			}
		}

		private void multiply_Click(object sender, EventArgs e)
		{
			if (input == string.Empty && result != 0)
			{
				operand1 = result.ToString();
				operation = '*';
				input = String.Empty;
			}
			else
			{
				operand1 = input;
				operation = '*';
				input = String.Empty;
			}
		}

		private void divide_Click(object sender, EventArgs e)
		{
			if (input == string.Empty && result != 0)
			{
				operand1 = result.ToString();
				operation = '/';
				input = String.Empty;
			}
			else
			{
				operand1 = input;
				operation = '/';
				input = String.Empty;
			}
		}

		private void clear_Click(object sender, EventArgs e)
		{
			this.textBox1.Text = "";
			this.input = string.Empty;
		}

		private void clearEverything_Click(object sender, EventArgs e)
		{
			this.textBox1.Text = "";
			this.input = string.Empty;
			this.operand1 = string.Empty;
			this.operand2 = string.Empty;
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
