//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NortHack
{
    using System;
    using System.Collections.Generic;
    
    public partial class Idea
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Idea()
        {
            this.Connection = new HashSet<Connection>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Owner { get; set; }
        public System.DateTime Date { get; set; }
        public string Category { get; set; }
        public Nullable<int> Likes { get; set; }
        public Nullable<int> Contributors { get; set; }
        public Nullable<int> Followers { get; set; }
        public string PictureUrl { get; set; }
        public string Pitch { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Connection> Connection { get; set; }
    }
}
