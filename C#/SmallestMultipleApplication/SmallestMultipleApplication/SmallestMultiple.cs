using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallestMultipleApplication
{
	class SmallestMultiple
	{
		public int getSmallest() {
			int num = 0;
			int checksum = 0;
			bool smallest = false;
			while (!smallest)
			{
				num+=20;
				for (int i = 1; i <= 20; i++)
				{
					if (num % i == 0)
					{
						checksum++;
					}
				}
				if (checksum == 20) {
					smallest = true;
				}
				checksum = 0;
			}
			return num;
		}
	}
}
