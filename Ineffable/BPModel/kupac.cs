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
    
    public partial class kupac
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public kupac()
        {
            this.radni_nalog_servisa = new HashSet<radni_nalog_servisa>();
            this.rezervacija = new HashSet<rezervacija>();
            this.poruke = new HashSet<poruke>();
            this.zahtjev_za_servis = new HashSet<zahtjev_za_servis>();
        }
    
        public int kupac_id { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public Nullable<int> korisnik_id { get; set; }
        public string obavijest { get; set; }
        public string obrazlozenje { get; set; }

        public override string ToString()
        {
            return ime + " " + prezime;
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<radni_nalog_servisa> radni_nalog_servisa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rezervacija> rezervacija { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<poruke> poruke { get; set; }
        public virtual korisnik korisnik { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<zahtjev_za_servis> zahtjev_za_servis { get; set; }
    }
}
