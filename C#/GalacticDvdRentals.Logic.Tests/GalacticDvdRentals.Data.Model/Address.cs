namespace GalacticDvdRentals.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Address")]
    public partial class Address
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Address()
        {
            Clients = new HashSet<Client>();
        }

        public int addressId { get; set; }

        public int clientid { get; set; }

        [Required]
        [StringLength(10)]
        public string poBox { get; set; }

        [Required]
        [StringLength(50)]
        public string line1 { get; set; }

        [Required]
        [StringLength(50)]
        public string line2 { get; set; }

        [Required]
        [StringLength(50)]
        public string city { get; set; }

        [Required]
        [StringLength(50)]
        public string region { get; set; }

        [StringLength(10)]
        public string code { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Client> Clients { get; set; }
    }
}
