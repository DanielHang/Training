using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumLargeApplication
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter Data to sum");
			List<string> data = new List<string>();
			for (int cnt = 0; cnt < 100; cnt++)
			{
				String OneLine = Console.ReadLine();
				data.Add(OneLine);
			}

			for (int cnt = 0; cnt < 100; cnt++)
			{
				Console.WriteLine("Line: {0} Number: {1}", cnt, data[cnt]);
			}

			int[] digitSum = new int[50];
			int tempDigit = 0;
			for (int digit = 49; digit >= 0; digit--)
			{
				for (int cnt = 0; cnt < 100; cnt++)
				{
					tempDigit = Convert.ToInt32(((data[cnt]).Substring(digit, 1)));
					Console.WriteLine("TempDigit: ", tempDigit);
					digitSum[digit] += tempDigit;

				}
			}
			
			for (int cnt = 0; cnt < 50; cnt++)
			{
				Console.WriteLine("Digit {0} Sum: {1}",cnt, digitSum[cnt]);
			}

			int[] digitCarry = new int[50];
			for (int digit = 49; digit >= 0; digit--)
			{
				Console.Write("Digit: {0} Sum: {1} ", digit, digitSum[digit]);
				if (digit != 49)
					digitSum[digit] += digitCarry[digit + 1];
				Console.Write("Sum+Carried: {0} ", digitSum[digit]);
				digitCarry[digit] = digitSum[digit] /10;
				if (digit != 0)
					digitSum[digit] %= 10;
				Console.WriteLine("SumAns = {0} Carry = {1}", digitSum[digit], digitCarry[digit]);
			}
			String sum = "";
			for (int digit = 0; digit < 50; digit++)
			{
				sum += digitSum[digit].ToString();
			}

			Console.WriteLine("Sum = {0}", sum);
			Console.WriteLine("Sum[First 10 digits] = {0}", sum.Substring(0,10));
			Console.ReadKey();
		}
	}
}
