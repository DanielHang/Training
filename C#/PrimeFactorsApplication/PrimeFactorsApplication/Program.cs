using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactorsApplication
{
	class Program
	{
		static void Main(string[] args)
		{
			PrimeFactor pf = new PrimeFactor();
			Console.WriteLine(pf.largest(600851475143));
			Console.ReadKey();
		}
	}
}
