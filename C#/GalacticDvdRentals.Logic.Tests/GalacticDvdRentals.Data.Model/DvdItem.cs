using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GalacticDvdRentals.Data.Model
{
	public class DvdItem
	{
		public int DvdItemId { get; set; }
		public int MovieId { get; set; }
		public int Price { get; set; }
		public int Serial { get; set; }

		public DvdItem()
		{
			Price = 250;
		}

		public override bool Equals(object obj)
		{
			if (obj == null)
				return false;

			if (!(obj is DvdItem))
				return false;

			var eq = (DvdItem)obj;
			return DvdItemId.Equals(eq.DvdItemId);
		}

		public override int GetHashCode()
		{
			return DvdItemId.GetHashCode();
		}
	}
}
