namespace GalacticDvdRentals.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Charge
    {
		public int chargeId { get; set; }

        public int clientId { get; set; }

        [Required]
        [StringLength(1)]
        public string chargeType { get; set; }

        public DateTime chargeDate { get; set; }

        public decimal amount { get; set; }

        public virtual Client Client { get; set; }
    }
}
