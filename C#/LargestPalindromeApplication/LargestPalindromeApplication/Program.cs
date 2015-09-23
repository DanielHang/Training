using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestPalindromeApplication
{
	class Program
	{
		static void Main(string[] args)
		{
			Palindrome lp = new Palindrome();
			Console.WriteLine("Largest Palindrome generated from the product of 2 three diget numbers: {0}", lp.getLargest(999));
			Console.ReadKey();
		}
	}
}
