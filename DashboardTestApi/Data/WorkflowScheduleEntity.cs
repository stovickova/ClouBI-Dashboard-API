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
    
    public partial class WorkflowScheduleEntity
    {
        public int Id { get; set; }
        public int WorkflowId { get; set; }
        public int ScheduleId { get; set; }
        public bool Enabled { get; set; }
    
        public virtual ScheduleEntity Schedule { get; set; }
        public virtual WorkflowEntity Workflow { get; set; }
    }
}
