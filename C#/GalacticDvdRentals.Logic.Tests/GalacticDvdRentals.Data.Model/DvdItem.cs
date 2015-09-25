namespace GalacticDvdRentals.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DVDItem")]
    public partial class DvdItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DvdItem()
        {
            Rentals = new HashSet<Rental>();
        }

		public int dvdItemId { get; set; }

        public int movieId { get; set; }

        [StringLength(50)]
        public string media { get; set; }

        [Required]
        [StringLength(15)]
        public string serial { get; set; }

        public int price { get; set; }

        public virtual Movie Movie { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rental> Rentals { get; set; }

		public override bool Equals(object obj)
		{
			var dvd = obj as DvdItem;
			if (dvd == null)
				return false;
			return dvdItemId == dvd.dvdItemId && movieId == dvd.movieId && media == dvd.media && serial == dvd.serial && price == dvd.price;
		}

		public override int GetHashCode()
		{
			return dvdItemId.GetHashCode();
		}

    }
}
