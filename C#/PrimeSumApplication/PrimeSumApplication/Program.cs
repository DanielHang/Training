using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeSumApplication
{
	class PrimeNumber
	{
		public bool isPrime(long test)
		{
			if (test <= 1)
				return false;
			long upperlim = (long)Math.Sqrt(test)+1;
			for (long i = 3; i <= upperlim; i+=2)
			{
				if (test % i == 0)
					return false;
			}
			Console.Write("{0}, ", test);
			return true;
		}

		static void Main(string[] args)
		{
			long sum = 2 + 5;
			long sum1 = 0;
			long sum3 = 0;
			long sum7 = 0;
			long sum9 = 0;
			long limit = 2000000;
			PrimeNumber pn = new PrimeNumber();
			for (long i = 1; i < limit; i++)
			{
				if (pn.isPrime(i))
					sum1 += i;
				i += 9;
			}
			for (long i = 3; i < limit; i++)
			{
				if (pn.isPrime(i))
					sum3 += i;
				i += 9;
			}
			for (long i = 7; i < limit; i++)
			{
				if (pn.isPrime(i))
					sum += i;
				i += 9;
			}
			for (long i = 9; i < limit; i++)
			{
				if (pn.isPrime(i))
					sum9 += i;
				i += 9;
			}


			sum += sum1 + sum3 + sum7 + sum9;
			Console.WriteLine("Sum: {0}", sum);

			Console.ReadKey();
		}
	}
}
