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
    
    public partial class usluga
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public usluga()
        {
            this.salonusluga = new HashSet<salonusluga>();
            this.zaposlenikusluga = new HashSet<zaposlenikusluga>();
            this.narudzba = new HashSet<narudzba>();
        }
    
        public int idusluga { get; set; }
        public string naziv { get; set; }
        public decimal cijena { get; set; }
        public int trajanje { get; set; }
        public string opis { get; set; }
        public int idKategorija { get; set; }
    
        public virtual kategorija kategorija { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<salonusluga> salonusluga { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<zaposlenikusluga> zaposlenikusluga { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<narudzba> narudzba { get; set; }
    }
}
