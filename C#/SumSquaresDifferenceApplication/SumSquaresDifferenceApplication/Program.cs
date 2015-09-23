using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSquaresDifferenceApplication
{
	class Program
	{
		static void Main(string[] args)
		{
			SumSquare ss = new SumSquare();
			Console.WriteLine("Difference between Sum of Squares and Square of Sums of first 100 natural numbers: {0}", ss.difference(100));
			Console.ReadKey();
		}
	}
}
