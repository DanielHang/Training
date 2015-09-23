using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GalacticDvdRentals.Data.Model
{
	public class Rental
	{
		public int RentalId { get; set; }
		public int DvdItemId { get; set; }
		public int ClientId { get; set; }
		public DateTime RentalDate { get; set; }
		public DateTime ExpectedReturnDate { get; set; }
		public DateTime? ReturnDate { get; set; }

		public override bool Equals(object obj)
		{
			if (obj == null)
				return false;

			if (!(obj is Rental))
				return false;

			var eq = (Rental)obj;
			return RentalId.Equals(eq.RentalId);
		}

		public override int GetHashCode()
		{
			return RentalId.GetHashCode();
		}
	}
}