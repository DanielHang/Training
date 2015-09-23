using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenFabonacciApplication
{
	class Program
	{
		static void Main(string[] args)
		{
			EvenFibonacci ef = new EvenFibonacci();
			Console.WriteLine("Sum of even Fibonacci Sequence numbers under 14 000 000: {0}", ef.getLimit(14000000));
			Console.ReadKey();
		}
	}
}
