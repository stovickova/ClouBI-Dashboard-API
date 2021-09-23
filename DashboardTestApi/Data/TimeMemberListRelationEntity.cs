//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DashboardTestApi.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class TimeMemberListRelationEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TimeMemberListRelationEntity()
        {
            this.TimeMemberRelations = new HashSet<TimeMemberRelationEntity>();
            this.TimeHierarchyLevelsAsChild = new HashSet<TimeHierarchyLevelEntity>();
            this.TimeHierarchyLevelsAsParent = new HashSet<TimeHierarchyLevelEntity>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public int ParentListId { get; set; }
        public int ChildListId { get; set; }
        public string Description { get; set; }
    
        public virtual TimeMemberListEntity ChildTimeMemberList { get; set; }
        public virtual TimeMemberListEntity ParentTimeMemberList { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TimeMemberRelationEntity> TimeMemberRelations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TimeHierarchyLevelEntity> TimeHierarchyLevelsAsChild { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TimeHierarchyLevelEntity> TimeHierarchyLevelsAsParent { get; set; }
    }
}