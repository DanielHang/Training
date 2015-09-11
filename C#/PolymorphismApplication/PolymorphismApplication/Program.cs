using System;
namespace PolymorphismApplication
{
	class Printdata
	{
		void print(int i)
		{
			Console.WriteLine("Printing int: {0}", i);
		}

		void print(double d)
		{
			Console.WriteLine("Printing double: {0}", d);
		}

		void print(string s)
		{
			Console.WriteLine("Printing string: {0}", s);
		}

		static void Main(string[] args)
		{
			Printdata p = new Printdata();

			p.print(5);
			p.print(500.263);
			p.print("Hello c++");

			Console.ReadKey();
		}
	}
}
