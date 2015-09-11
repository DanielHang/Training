using System;
namespace InheritanceApplication
{
/*	// Base Class
	class Shape
	{
		public void setWidth(int w)
		{
			width = w;
		}
		public void setHeight(int h)
		{
			height = h;
		}
		protected int width;
		protected int height;
	}

     // Derived Class
	class Rectangle : Shape
	{
		public int getArea()
		{
			return (width * height);
		}
	}
*/
	//Base Class
	class Rectangle
	{
		protected double length;
		protected double width;

		public Rectangle(double l, double w)
		{
			length = l;
			width = w;
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

	//Derived Class
	class Tabletop : Rectangle
	{
		private double cost;
		public Tabletop(double l, double w)
			: base(l, w)
		{	}
		public double GetCost()
		{
			double cost;
			cost = GetArea() * 70;
			return cost;
		}

		public void Display()
		{
			base.Display();
			Console.WriteLine("Cost: {0}", GetCost());
		}
	}

	class RectangleTester
	{
		static void Main(string[] args)
		{
/*			Rectangle Rect = new Rectangle();
			Rect.setWidth(5);
			Rect.setHeight(7);
			Console.WriteLine("Total area: {0}", Rect.getArea());
*/
			Tabletop t = new Tabletop(4.5, 7.5);
			t.Display();			
			
			Console.ReadKey();
		}
	}
}
