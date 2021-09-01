//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Adelante.Core.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class ActiveNeighborhood
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ActiveNeighborhood()
        {
            this.ClientAccesses = new HashSet<ClientAccess>();
            this.ClientAddresses = new HashSet<ClientAddress>();
            this.ClientNeighborhoods = new HashSet<ClientNeighborhood>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> NeighborhoodId { get; set; }
        public Nullable<bool> Active { get; set; }
    
        public virtual Neighborhood Neighborhood { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientAccess> ClientAccesses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientAddress> ClientAddresses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientNeighborhood> ClientNeighborhoods { get; set; }
    }
}
