//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyBanHang.AppData
{
    using System;
    using System.Collections.Generic;
    
    public partial class SYS_GROUP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SYS_GROUP()
        {
            this.SYS_USER_RULE = new HashSet<SYS_USER_RULE>();
            this.SYS_USER = new HashSet<SYS_USER>();
        }
    
        public string Group_ID { get; set; }
        public string GroupName { get; set; }
        public string Description { get; set; }
        public Nullable<bool> Active { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SYS_USER_RULE> SYS_USER_RULE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SYS_USER> SYS_USER { get; set; }
    }
}