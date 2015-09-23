using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LargestProductApplication
{
	class GreatestProduct
	{
		public string product(String testString)
		{
			int len = testString.Length;
			long greatest = 0;
			long test = 1;
			int adjacent = 13;
			for (int i = 0; i <= (len - adjacent); i++)
			{
				for (int j = 0; j < adjacent; j++)
				{
					test = test * int.Parse(testString[i+j].ToString());
					Console.Write("{0} ", int.Parse(testString[i+j].ToString()));
				}
				Console.Write(": Product = {0} ", test);
				if (greatest < test) {
					greatest = test;
					Console.Write(" GREATEST");
				}
				test = 1;
				Console.WriteLine();
			}
			return greatest.ToString();
		}
	}
}
