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
    
    public partial class smjena
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public smjena()
        {
            this.zaposlenik = new HashSet<zaposlenik>();
        }
    
        public int idSmjena { get; set; }
        public string smjena1 { get; set; }
        public System.TimeSpan timeStart { get; set; }
        public System.TimeSpan timeEnd { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<zaposlenik> zaposlenik { get; set; }
    }
}
