using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace PowerDigitSumApplication
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("***Power Digit Sum***");
			Console.WriteLine();
			int index = 1000;
			long sum = 0;

			sum = digitSum(powerOf(2, index));
			Console.WriteLine("The sum of the digets of 2 to the power of {1} is: {0}", sum, index);
			Console.ReadKey();
		}

		private static BigInteger powerOf(int num, int index)
		{
			BigInteger power = 1;
			for (int i = 1; i <= index; i++)
			{
				power *= num;
			}
			return power;
		}

		private static long digitSum(BigInteger power)
		{
			long sum = 0;
			BigInteger num = power;
			while (num >= 10)
			{
				sum += (long)(num % 10);
				num /= 10;
			}
			sum += (long)num;
			return sum;
		}
	}
}
