using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EvenFabonacciApplication
{
	class EvenFibonacci
	{
		internal int getLimit(int upperLimit)
		{
			int sum = 2;
			int f1 = 1;
			int f2 = 2;
			int f3 = 0;
			/*Fibonacci Generator*/
			while (f3 < upperLimit) {
				/*Calculate next number in sequence*/
				f3 = f1+f2;
				/*Shit old numbers up in sequence*/
				f1 = f2; 
				f2 = f3;
				if ((f3 % 2 == 0) && (f3 < upperLimit))
				{
					sum += f3;
				}
			}
			return sum;
		}
	}
}
