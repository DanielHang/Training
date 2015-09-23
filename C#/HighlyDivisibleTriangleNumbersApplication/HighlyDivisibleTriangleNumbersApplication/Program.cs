using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighlyDivisibleTriangleNumbersApplication
{
	class Program
	{
		static void Main(string[] args)
		{
			long triangle = 0;
			long divisors = 0;
			long cnt =1;
			const long divisorLim = 500;

			do
			{
				triangle += cnt;
				cnt++;
				divisors = 0;
				long lim = (long)Math.Sqrt(triangle);
				if (lim * lim == triangle)
					divisors--;
				Console.Write("Triangle: {0} Divisors: ", triangle);
				for (int i = 1; i < lim; i++)
				{
					if (triangle % i == 0)
					{
						divisors+=2;
						Console.Write("{0} ", i);
					}
				}
				Console.Write("{0} ", triangle);
				Console.WriteLine();
			} while (divisors < divisorLim);


			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("Triangle: {0}", triangle);
			Console.ReadKey();
		}
	}
}
