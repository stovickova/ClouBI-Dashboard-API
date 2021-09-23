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
    
    public partial class ModelDimensionalityEntity
    {
        public int Id { get; set; }
        public int ModelId { get; set; }
        public int DimHierarchyId { get; set; }
        public int DimDetailLevelId { get; set; }
        public int TimeHierarchyId { get; set; }
        public int TimeDetailLevelId { get; set; }
    
        public virtual HierarchyEntity Hierarchy { get; set; }
        public virtual HierarchyLevelEntity HierarchyLevel { get; set; }
        public virtual TimeHierarchyEntity TimeHierarchy { get; set; }
        public virtual TimeHierarchyLevelEntity TimeHierarchyLevel { get; set; }
        public virtual ModelEntity Model { get; set; }
    }
}
