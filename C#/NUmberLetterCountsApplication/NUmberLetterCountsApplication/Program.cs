using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUmberLetterCountsApplication
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("***Numbers to Words Counting***");
			int sum = 0, startNum = 1, stopNum = 1000;
			
			string tempNum;
			for (int cnt = startNum; cnt <= stopNum; cnt++)
			{
				tempNum = NumberToWords(cnt);
				Console.WriteLine("{0} : {1}", tempNum, NumCount(tempNum));
				sum += NumCount(tempNum);
			}

			Console.WriteLine();
			Console.WriteLine("There are {0} letters from {1} to {2}", sum, startNum, stopNum);
			Console.ReadKey();

		}

		private static int NumCount(string tempNum)
		{
			tempNum = tempNum.Replace(" ", "");
			tempNum = tempNum.Replace("-", "");

			return tempNum.Length;
		}



		public static string NumberToWords(int number)
		{
			if (number == 0)
				return "zero";

			if (number < 0)
				return "minus " + NumberToWords(Math.Abs(number));

			string words = "";

			if ((number / 1000000) > 0)
			{
				words += NumberToWords(number / 1000000) + " million ";
				number %= 1000000;
			}

			if ((number / 1000) > 0)
			{
				words += NumberToWords(number / 1000) + " thousand ";
				number %= 1000;
			}

			if ((number / 100) > 0)
			{
				words += NumberToWords(number / 100) + " hundred ";
				number %= 100;
			}

			if (number > 0)
			{
				if (words != "")
					words += "and ";

				var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
				var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

				if (number < 20)
					words += unitsMap[number];
				else
				{
					words += tensMap[number / 10];
					if ((number % 10) > 0)
						words += "-" + unitsMap[number % 10];
				}
			}

			return words;
		}
	}
}
