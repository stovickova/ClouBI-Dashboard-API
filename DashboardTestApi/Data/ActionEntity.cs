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
    
    public partial class ActionEntity
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<int> OutputId { get; set; }
        public Nullable<System.DateTime> ValidTo { get; set; }
        public System.DateTime ValidFrom { get; set; }
        public double Weight { get; set; }
        public int ParentObjectId { get; set; }
        public short ParentType { get; set; }
    
        public virtual OutputEntity Output { get; set; }
    }
}