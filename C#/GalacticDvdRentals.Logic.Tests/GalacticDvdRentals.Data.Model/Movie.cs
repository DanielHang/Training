namespace GalacticDvdRentals.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Movie")]
    public partial class Movie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Movie()
        {
            DVDItems = new HashSet<DvdItem>();
        }

		public int movieId { get; set; }

        [Required]
        [StringLength(50)]
        public string title { get; set; }

        [StringLength(50)]
        public string description { get; set; }

        [Column(TypeName = "image")]
        public byte[] image { get; set; }

        [StringLength(50)]
        public string stars { get; set; }

        [StringLength(50)]
        public string ageRestriction { get; set; }

        [StringLength(50)]
        public string director { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DvdItem> DVDItems { get; set; }

		public override bool Equals(object obj)
		{
			var m = obj as Movie;
			if (m == null)
				return false;
			return movieId == m.movieId && title == m.title && description == m.description && stars == m.stars && ageRestriction == m.ageRestriction && director == m.director;
		}

		public override int GetHashCode()
		{
			return movieId.GetHashCode();
		}

    }
}
