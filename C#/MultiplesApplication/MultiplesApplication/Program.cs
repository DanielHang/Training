using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplesApplication
{
	class Program
	{
		static void Main(string[] args)
		{
			/*List all the multiples of 3 and 5 below 1000 and add them together*/
			int sum = 0;
			MultipleMaker mm = new MultipleMaker();
			sum = mm.getsum(3, 1000);
			sum += mm.getsum(5, 1000, 3);
			Console.WriteLine("Multiples of 3 and 5 less than 1000 summed: {0}", sum);
			Console.ReadKey();
		}
	}
}
