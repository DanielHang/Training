using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace SumLargeApplication
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter Data to sum");
			List<BigInteger> data = new List<BigInteger>();
			for (int cnt = 0; cnt < 100; cnt++)
			{
				String OneLine = Console.ReadLine();
				data.Add(BigInteger.Parse(OneLine));
			}

			for (int cnt = 0; cnt < 100; cnt++)
			{
				Console.WriteLine("Line: {0} Number: {1}", cnt, data[cnt]);
			}

			BigInteger sum = 0;
			for (int cnt = 0; cnt < 100; cnt++)
			{
					sum += data[cnt];
			}
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("Sum = {0}", sum);
			Console.WriteLine("Sum[First 10 digits] = {0}", sum.ToString().Substring(0,10));
			Console.ReadKey();
		}
	}
}
