using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PythagoreanTripletApplication
{
	class Program
	{
		static void Main(string[] args)
		{
			int d = 1000;
			for (int a = 1; a <= d; a++) {
				for (int b = 1; b <= d; b++) {
					for (int c = 1; c <= d; c++) {
						if ((a * a + b * b == c * c) && (a + b + c == d))
							Console.WriteLine("a={0}, b={1}, c={2}, , tripple={3}, abc={4}", a, b, c, (a + b + c), a * b * c);
					}
				}
			}

			Console.ReadKey();
		}
	}
}
