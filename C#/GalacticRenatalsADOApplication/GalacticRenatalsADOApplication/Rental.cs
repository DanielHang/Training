//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GalacticRenatalsADOApplication
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rental
    {
        public int clientId { get; set; }
        public int dvdItemId { get; set; }
        public System.DateTime rentalDate { get; set; }
        public System.DateTime expectedReturnDate { get; set; }
        public Nullable<System.DateTime> actualRetunDate { get; set; }
        public int rentalId { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual DVDItem DVDItem { get; set; }
    }
}
