//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace C19_Tracker
{
    using System;
    using System.Collections.Generic;
    
    public partial class Orvo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Orvo()
        {
            this.Beosztas = new HashSet<Beoszta>();
            this.Betegs = new HashSet<Beteg>();
        }
    
        public int OrvosID { get; set; }
        public string OrvosNev { get; set; }
        public string Pozicio { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Beoszta> Beosztas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Beteg> Betegs { get; set; }
    }
}
