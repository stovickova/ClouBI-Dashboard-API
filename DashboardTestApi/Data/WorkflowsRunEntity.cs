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
    
    public partial class WorkflowsRunEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WorkflowsRunEntity()
        {
            this.StepRunLogs = new HashSet<StepRunLogEntity>();
        }
    
        public int Id { get; set; }
        public int WorkflowId { get; set; }
        public Nullable<int> StartType { get; set; }
        public Nullable<System.DateTime> StartDateTime { get; set; }
        public Nullable<int> StartUserId { get; set; }
        public Nullable<int> StartStepId { get; set; }
        public Nullable<int> ActiveStepId { get; set; }
        public Nullable<int> ActiveStepResult { get; set; }
        public Nullable<bool> ConfirmRequest { get; set; }
        public Nullable<System.DateTime> ConfirmDateTime { get; set; }
        public Nullable<int> ConfirmUserId { get; set; }
        public Nullable<bool> CancelRequest { get; set; }
        public Nullable<System.DateTime> CancelDateTime { get; set; }
        public Nullable<int> CancelUserId { get; set; }
        public Nullable<int> Result { get; set; }
        public Nullable<System.DateTime> EndDateTime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StepRunLogEntity> StepRunLogs { get; set; }
        public virtual WorkflowEntity Workflow { get; set; }
    }
}
