using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimNumberApplication
{

	class PrimeNumber
	{
		public bool isPrime(long test)
		{
			for (long i = 2; i <= test / 2; i++)
			{
				if (test % i == 0)
				{
					return false;
				}

			}
			return true;
		}
		public void printPrime(int primeFinal)
		{
			int PrimeCount = 0;
			long testNum = 1;
			while (PrimeCount <= primeFinal)
			{
				if (isPrime(testNum))
				{
					Console.WriteLine("{0} prime number is : {1}", PrimeCount, testNum);
					PrimeCount++;
				}
				testNum++;
			}
		}
	}
}
