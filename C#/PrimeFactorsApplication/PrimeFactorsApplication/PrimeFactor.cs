using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeFactorsApplication
{
	class PrimeFactor
	{
		bool isPrime(long num)
		{
			if (num % 2 == 0)
			{
				return false;
			}
			for (int i = 3; i < num; i+=2)
			{
				if (num % i == 0) {
					return false;
				}
			}
				return true;
		}

		internal long largest(long targetNum)
		{
			for (long i = 1; i < targetNum; i++)
			{
				if (targetNum % i == 0) {
					if (isPrime(targetNum/i))
					{
						return targetNum/i;
					}
				}
			}
			return 0;
		}
	}
}