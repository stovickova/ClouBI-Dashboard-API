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
    
    public partial class RuleDimRowEntity
    {
        public int Id { get; set; }
        public int RuleId { get; set; }
        public int DimMemberId { get; set; }
        public Nullable<double> Value { get; set; }
    
        public virtual RuleEntity Rule { get; set; }
    }
}
