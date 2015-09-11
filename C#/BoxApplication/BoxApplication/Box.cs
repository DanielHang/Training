using System;
namespace BoxApplication
{
	class Box
	{
		private double height;
		private double length;
		private double breadth;

		public void setHeight(double hei)
		{
			height = hei;
		}

		public void setLength(double len)
		{
			length = len;
		}

		public void setBreadth(double bre)
		{
			breadth = bre;
		}

		public double getVolume()
		{
			return height * length * breadth;
		}
	}
}
