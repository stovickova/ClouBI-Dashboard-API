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
    
    public partial class ModelValueSourceEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ModelValueSourceEntity()
        {
            this.ModelValueSourceDimLevels = new HashSet<ModelValueSourceDimLevelEntity>();
            this.ModelValueSourceTimeLevels = new HashSet<ModelValueSourceTimeLevelEntity>();
            this.ModelValueDimFilters = new HashSet<ModelValueDimFilterEntity>();
            this.ModelValueIndicatorFilters = new HashSet<ModelValueIndicatorFilterEntity>();
            this.ModelValueTimeFilters = new HashSet<ModelValueTimeFilterEntity>();
        }
    
        public int Id { get; set; }
        public int ModelId { get; set; }
        public int PlanId { get; set; }
        public int TimeDetailLevelId { get; set; }
        public byte TimeInputTypeId { get; set; }
        public int DimDetailLevelId { get; set; }
        public Nullable<int> ReportId { get; set; }
        public string SourceName { get; set; }
        public string Description { get; set; }
        public int DimFilterType { get; set; }
        public int TimeFilterType { get; set; }
        public int IndicatorFilterType { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ModelValueSourceDimLevelEntity> ModelValueSourceDimLevels { get; set; }
        public virtual HierarchyLevelEntity HierarchyLevel { get; set; }
        public virtual ModelEntity Model { get; set; }
        public virtual TimeHierarchyLevelEntity TimeHierarchyLevel { get; set; }
        public virtual TimeInputTypeEntity TimeInputType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ModelValueSourceTimeLevelEntity> ModelValueSourceTimeLevels { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ModelValueDimFilterEntity> ModelValueDimFilters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ModelValueIndicatorFilterEntity> ModelValueIndicatorFilters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ModelValueTimeFilterEntity> ModelValueTimeFilters { get; set; }
    }
}