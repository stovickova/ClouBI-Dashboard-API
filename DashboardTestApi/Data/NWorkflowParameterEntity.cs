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
    
    public partial class NWorkflowParameterEntity
    {
        public int Id { get; set; }
        public System.Guid UId { get; set; }
        public System.Guid WorkflowUId { get; set; }
        public string Name { get; set; }
        public short IOType { get; set; }
        public byte[] DefaultValue { get; set; }
        public bool CanPassNull { get; set; }
        public string Datatype { get; set; }
        public string SubDatatype { get; set; }
        public System.Guid ParentObjectUId { get; set; }
        public Nullable<System.Guid> ChildObjectUId { get; set; }
        public System.Guid SubId { get; set; }
        public bool IsDefinition { get; set; }
        public bool IsCustom { get; set; }
    }
}
