//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GalacticRentalsADOModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class DVDItem
    {
        public DVDItem()
        {
            this.Rentals = new HashSet<Rental>();
        }
    
        public int dvdItemId { get; set; }
        public int movie { get; set; }
        public string media { get; set; }
        public string serial { get; set; }
    
        public virtual Movie Movie1 { get; set; }
        public virtual ICollection<Rental> Rentals { get; set; }
    }
}
