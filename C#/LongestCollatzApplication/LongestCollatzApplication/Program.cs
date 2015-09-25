using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestCollatzApplication
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("***Longest Collatz Sequence***");


			int limit = 1000000;
			int longestSequence = 0;
			long longestSequenceLength = 0;
			long currentSequenceLength = 0;
			for (int currentSequence = 1; currentSequence < limit; currentSequence++)
			{
				Console.Write("{0} :", currentSequence);
				currentSequenceLength = CollatzLength(currentSequence);
				Console.WriteLine("Terms : {0}", currentSequenceLength);
				if (currentSequenceLength > longestSequenceLength)
				{
					longestSequence = currentSequence;
					longestSequenceLength = currentSequenceLength;
				}
			}

			Console.WriteLine("The Collatz Sequence starting with {0} has {1} terms",longestSequence, longestSequenceLength);
			Console.ReadKey();
		}

		private static long CollatzLength(int startTerm)
		{
			long sequenceCounter = 0;
			long sequenceTerm = startTerm;
			while (true)
			{
				sequenceCounter++;
			//	Console.Write("{0} ", sequenceTerm);
				if (sequenceTerm == 1)
					return sequenceCounter;
				if (sequenceTerm % 2 == 1)
					sequenceTerm = (3 * sequenceTerm) + 1;
				else
					sequenceTerm /= 2;
			}
		}
	}
}
