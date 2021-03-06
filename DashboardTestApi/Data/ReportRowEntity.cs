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
    
    public partial class ReportRowEntity
    {
        public int Id { get; set; }
        public int ReportId { get; set; }
        public Nullable<int> IndicatorId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public double SortOrder { get; set; }
        public Nullable<bool> BiggerBetter { get; set; }
        public Nullable<double> RedIfZero { get; set; }
        public string Description { get; set; }
        public Nullable<double> Weight { get; set; }
        public Nullable<System.DateTime> ValidFrom { get; set; }
        public Nullable<System.DateTime> ValidTo { get; set; }
        public Nullable<int> OutputId { get; set; }
        public Nullable<decimal> RedThreshold { get; set; }
        public Nullable<int> MemberId { get; set; }
        public string Expression { get; set; }
        public string Day { get; set; }
        public string Frequency { get; set; }
        public bool ForOLAP { get; set; }
    
        public virtual IndicatorEntity Indicator { get; set; }
        public virtual ReportEntity Report { get; set; }
    }
}
