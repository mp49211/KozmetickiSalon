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
    
    public partial class nabavaartikl
    {
        public int idNabavaArtikl { get; set; }
        public int idNabava { get; set; }
        public int idArtikl { get; set; }
        public int kolicina { get; set; }
    
        public virtual artikl artikl { get; set; }
        public virtual nabava nabava { get; set; }
    }
}
