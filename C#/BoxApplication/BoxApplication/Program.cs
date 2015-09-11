using System;
namespace BoxApplication
{
	class BoxTester
	{
		static void Main(string[] args)
		{
			/*Declare variables*/
			Box Box1 = new Box();
			Box Box2 = new Box();
			double volume;

			// Box1 Specs
			Box1.setHeight(5.0);
			Box1.setLength(6.0);
			Box1.setBreadth(7.0);

			// Box2 Specs
			Box2.setHeight(10.0);
			Box2.setLength(12.0);
			Box2.setBreadth(13.0);

			// Volume of Box1
			volume = Box1.getVolume();
			Console.WriteLine("Volume of Box1 : {0}", volume);

			// Volume of Box1
			volume = Box2.getVolume();
			Console.WriteLine("Volume of Box2 : {0}", volume);

			Console.ReadKey();
		}
	}
}
