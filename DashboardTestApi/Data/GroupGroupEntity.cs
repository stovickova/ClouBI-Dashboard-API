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
    
    public partial class GroupGroupEntity
    {
        public int Id { get; set; }
        public int ParentGroupId { get; set; }
        public int ChildGroupId { get; set; }
    
        public virtual GroupEntity Group { get; set; }
        public virtual GroupEntity Group1 { get; set; }
    }
}
