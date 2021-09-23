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
    
    public partial class WorkflowStepEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WorkflowStepEntity()
        {
            this.WorkflowStepDetails = new HashSet<WorkflowStepDetailEntity>();
            this.StepParametersValues = new HashSet<StepParametersValueEntity>();
        }
    
        public int Id { get; set; }
        public int OrderNo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int WorkflowId { get; set; }
        public int WorkflowStepTypeId { get; set; }
        public bool ManualyConfirm { get; set; }
        public Nullable<int> ModelId { get; set; }
    
        public virtual WorkflowEntity Workflow { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkflowStepDetailEntity> WorkflowStepDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StepParametersValueEntity> StepParametersValues { get; set; }
        public virtual ModelEntity Model { get; set; }
        public virtual WorkflowStepTypeEntity WorkflowStepType { get; set; }
    }
}
