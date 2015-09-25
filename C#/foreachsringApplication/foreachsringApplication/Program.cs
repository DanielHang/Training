using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foreachsringApplication
{
	class Program
	{
		private const string MovieTitle1 = "qwaljknbefec";
		private const string MovieTitle2 = "qwaljknbefec";
		private const string MovieTitle3 = "qwfdsKIUJBe";
		private const string MovieTitle4 = "QqSyXabcDGFJYwe";
		private const string MovieTitle5 = "qwXHFSWaerce";
		private const string MovieTitle6 = "hkjgABcertabc";
		private const string MovieTitle7 = "qrtcq2we";
		private const string MovieTitle8 = "a B c";
		private const string MovieTitle9 = "qwdfbede";
		private const string MovieTitle10 = "aw4mn";

		static void Main(string[] args)
		{
			printNames(MovieTitle1, MovieTitle2, MovieTitle3, MovieTitle4, MovieTitle5, MovieTitle6, MovieTitle7, MovieTitle8, MovieTitle9, MovieTitle10);
			Console.ReadKey();
		}

		private static void printNames(params string[] names)
		{

			foreach (string name in names)
			{
				Console.WriteLine("Number: {0} Name: {1}", names.GetEnumerator(), name);
			}
		}
	}
}
