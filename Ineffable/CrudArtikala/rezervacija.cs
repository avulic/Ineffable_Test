//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CrudArtikala
{
    using System;
    using System.Collections.Generic;
    
    public partial class rezervacija
    {
        public int rezervacija_id { get; set; }
        public Nullable<System.DateTime> vrijeme_rezervacije { get; set; }
        public Nullable<int> kolicina { get; set; }
        public int artikl_id { get; set; }
        public int kupac_id { get; set; }
    
        public virtual artikl artikl { get; set; }
        public virtual kupac kupac { get; set; }
    }
}
