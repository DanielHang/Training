using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestMultipleApplication
{
	class Program
	{
		static void Main(string[] args)
		{
			SmallestMultiple sm = new SmallestMultiple();
			Console.WriteLine("Smallest multiple of 1 to 20 is : {0}", sm.getSmallest());
			Console.ReadKey();
		}
	}
}
