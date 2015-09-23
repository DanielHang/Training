using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate2Application
{
	class Program
	{
		static void Main(string[] args)
		{
			PropertyListing listing = new PropertyListing();

			listing.CreateListing();
			Console.WriteLine("\n");
			listing.ShowProperty();
			Console.WriteLine();
			Console.ReadKey();
		}
	}
}
