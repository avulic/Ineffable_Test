//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BPModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class racun
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public racun()
        {
            this.stavka_racuna = new HashSet<stavka_racuna>();
        }
    
        public int racun_id { get; set; }
        public Nullable<System.DateTime> datum { get; set; }
        public Nullable<System.TimeSpan> vrijeme { get; set; }
        public Nullable<double> iznos { get; set; }
        public int zaposlenik_id { get; set; }
        public Nullable<int> servis_id { get; set; }
    
        public virtual korisnik korisnik { get; set; }
        public virtual radni_nalog_servisa radni_nalog_servisa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<stavka_racuna> stavka_racuna { get; set; }
    }
}
