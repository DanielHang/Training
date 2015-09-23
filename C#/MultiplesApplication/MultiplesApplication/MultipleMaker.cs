using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultiplesApplication
{
	class MultipleMaker
	{
		internal int getsum(int startNum, int upperLimit)
		{
			int multiple = 0;
			int multipleTotal = 0;
			while ((multiple + startNum) < upperLimit)
			{
				multiple += startNum;
				Console.WriteLine(multiple);
				multipleTotal += multiple;
			}
			return multipleTotal;
		}

		internal int getsum(int startNum, int upperLimit, int avoidMultiple)
		{
			int multiple = 0;
			int multipleTotal = 0;
			while ((multiple + startNum) < upperLimit)
			{
				multiple += startNum;
				Console.WriteLine(multiple);
				if (multiple % avoidMultiple != 0)
				{
					multipleTotal += multiple;
				} 
				
			}
			return multipleTotal;
		}
	}
}
