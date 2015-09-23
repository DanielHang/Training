using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SumSquaresDifferenceApplication
{
	class SumSquare
	{
		internal int difference(int num)
		{
			int sum = 0;
			int sumsq = 0;
			int sqsum = 0;

			for (int i = 1; i <= num; i++)
			{
				sqsum += (i * i);
				sum += i;
			}
			sumsq = sum * sum;

			return sumsq - sqsum;
		}
	}
}
