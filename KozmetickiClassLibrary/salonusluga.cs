//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KozmetickiClassLibrary
{
    using System;
    using System.Collections.Generic;
    
    public partial class salonusluga
    {
        public int idSalonUsluga { get; set; }
        public int idSalon { get; set; }
        public int idUsluga { get; set; }
    
        public virtual salon salon { get; set; }
        public virtual usluga usluga { get; set; }
    }
}
