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
    
    public partial class poruke
    {
        public int id { get; set; }
        public string tekst { get; set; }
        public int kupac_id { get; set; }
        public int servis_id { get; set; }
    
        public virtual kupac kupac { get; set; }
        public virtual radni_nalog_servisa radni_nalog_servisa { get; set; }
    }
}
