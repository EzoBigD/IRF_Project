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
    
    public partial class Agy
    {
        public int AgyID { get; set; }
        public int TeremFK { get; set; }
        public bool Foglalt { get; set; }
        public Nullable<int> JelenlegiBetegFK { get; set; }
    
        public virtual Beteg Beteg { get; set; }
        public virtual Terem Terem { get; set; }
    }
}