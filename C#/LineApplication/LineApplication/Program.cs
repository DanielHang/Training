using System;
namespace LineApplication
{
	class Line
	{
		public double length;
		public Line()
		{
			Console.WriteLine("Object is being created");
		}
		~Line()
		{
			Console.WriteLine("Object is being deleted");
		}
		public void setLength(double len)
		{
			length = len;
		}

		public double getLength()
		{
			return length;
		}

		static void Main(string[] args)
		{
			Line line = new Line();

			// set line length
			line.setLength(6.0);
			Console.WriteLine("Length of line: {0}", line.getLength());

			Console.ReadKey();
		}
	}
}
