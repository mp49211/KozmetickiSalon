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
    
    public partial class artikl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public artikl()
        {
            this.artiklsalon = new HashSet<artiklsalon>();
            this.nabavaartikl = new HashSet<nabavaartikl>();
        }
    
        public int idArtikl { get; set; }
        public string naziv { get; set; }
        public decimal cijena { get; set; }
        public int idDobavljac { get; set; }
        public int idProizvodac { get; set; }
        public int idKategorija { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<artiklsalon> artiklsalon { get; set; }
        public virtual kategorija kategorija { get; set; }
        public virtual proizvodac proizvodac { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<nabavaartikl> nabavaartikl { get; set; }
        public virtual dobavljac dobavljac { get; set; }
    }
}
