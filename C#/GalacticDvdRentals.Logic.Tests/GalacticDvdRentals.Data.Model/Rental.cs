namespace GalacticDvdRentals.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Rental
    {
        public int clientId { get; set; }

        public int dvdItemId { get; set; }

        public DateTime rentalDate { get; set; }

        public DateTime expectedReturnDate { get; set; }

        public DateTime? actualReturnDate { get; set; }

        public int rentalId { get; set; }

        public virtual Client Client { get; set; }

        public virtual DvdItem DVDItem { get; set; }

		public override bool Equals(object obj)
		{
			var r = obj as Rental;
			if (r == null)
				return false;
			return rentalId == r.rentalId && clientId == r.clientId && dvdItemId == r.dvdItemId && rentalDate == r.rentalDate && expectedReturnDate == r.expectedReturnDate && actualReturnDate == r.actualReturnDate; 
		}

		public override int GetHashCode()
		{
			return rentalId.GetHashCode();
		}
    }
}
