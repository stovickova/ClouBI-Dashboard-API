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
    
    public partial class StepRunLogEntity
    {
        public int Id { get; set; }
        public int WorkflowRunId { get; set; }
        public int StepId { get; set; }
        public System.DateTime Datetime { get; set; }
        public int Result { get; set; }
        public int UserId { get; set; }
        public string Text { get; set; }
    
        public virtual WorkflowsRunEntity WorkflowsRun { get; set; }
    }
}
