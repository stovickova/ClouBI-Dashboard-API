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
    
    public partial class ModelValueIndicatorFilterEntity
    {
        public int Id { get; set; }
        public int ModelValueSourceId { get; set; }
        public int IndicatorId { get; set; }
    
        public virtual ModelValueSourceEntity ModelValueSource { get; set; }
    }
}