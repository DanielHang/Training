using System;
namespace RectangleApplication
{
	class Rectangle
	{
		// member variables
		/* //Accessible as regular variables inside class
		double length;
		double width;
		*/

		/* //publically accessable from outside class
		public double length;
		public double width;
		*/

		/*
		// privately accessable, only by this class
		private double length;
		private double width;
		*/

		//Accessable to functions and objects in current assembly
		internal double length;
		internal double width;
		

		/*public void Acceptdetails()
		{
			length = 4.5;
			width = 3.5;
		}*/

		public void Acceptdetails()
		{
			Console.WriteLine("Enter Length: ");
			length = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Enter Width: ");
			width = Convert.ToDouble(Console.ReadLine());
		}

		public double GetArea()
		{
			return length * width;
		}

		public void Display()
		{
			Console.WriteLine("Length: {0}", length);
			Console.WriteLine("Width: {0}", width);
			Console.WriteLine("Area: {0}", GetArea());
		}
	}

	class ExcecuteRectangle
	{
		static void Main(string[] args)
		{
			Rectangle r = new Rectangle();
			//r.Acceptdetails();
			//r.length = 4.5;
			//r.width = 3.5;
			//r.Acceptdetails();
			r.length = 4.5;
			r.width = 3.5;
			r.Display();
			Console.ReadLine();
		}
	}
}
