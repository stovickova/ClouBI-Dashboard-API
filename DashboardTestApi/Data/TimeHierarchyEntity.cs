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
    
    public partial class TimeHierarchyEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TimeHierarchyEntity()
        {
            this.TimeHierarchyLevels = new HashSet<TimeHierarchyLevelEntity>();
            this.ModelIndicators = new HashSet<ModelIndicatorEntity>();
            this.ModelDimensionalities = new HashSet<ModelDimensionalityEntity>();
        }
    
        public int Id { get; set; }
        public int DimensionId { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Description { get; set; }
        public string OlapHierarchyId { get; set; }
    
        public virtual TimeDimensionEntity TimeDimension { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TimeHierarchyLevelEntity> TimeHierarchyLevels { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ModelIndicatorEntity> ModelIndicators { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ModelDimensionalityEntity> ModelDimensionalities { get; set; }
    }
}