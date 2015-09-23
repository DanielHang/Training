using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimNumberApplication
{
	class Program
	{
		static void Main(string[] args)
		{
			PrimeNumber pn = new PrimeNumber();
			pn.printPrime(10001);
			Console.ReadKey();
		}
	}
}
