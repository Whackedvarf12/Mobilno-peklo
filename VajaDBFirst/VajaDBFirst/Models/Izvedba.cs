//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VajaDBFirst.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Izvedba
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Izvedba()
        {
            this.IzvedbaDijak = new HashSet<IzvedbaDijak>();
            this.IzvedbaMentor = new HashSet<IzvedbaMentor>();
            this.Slike = new HashSet<Slike>();
        }
    
        public int IzvID { get; set; }
        public Nullable<System.DateTime> IzvDatum { get; set; }
        public Nullable<int> IzvMesec { get; set; }
        public Nullable<int> IzvLeto { get; set; }
        public string IzvOpis { get; set; }
        public Nullable<int> IzvPodročje { get; set; }
        public Nullable<int> IzvUre { get; set; }
        public string IzvCilji { get; set; }
        public string IzvUstanova { get; set; }
        public string IzvKraj { get; set; }
    
        public virtual Področja Področja { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IzvedbaDijak> IzvedbaDijak { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IzvedbaMentor> IzvedbaMentor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Slike> Slike { get; set; }
    }
}
