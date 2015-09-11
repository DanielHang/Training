﻿using System;
namespace UserDefinedExceptionApplication
{
	public class Temperature
	{
		int temperature = 0;
		public void showTemp()
		{
			if (temperature == 0)
			{
				throw (new TempIsZeroException("Zero Temperature found"));
			}
			else
			{
				Console.WriteLine("Temperature: {0}", temperature);
			}
		}
	}
}
