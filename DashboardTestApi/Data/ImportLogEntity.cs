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
    
    public partial class ImportLogEntity
    {
        public int Id { get; set; }
        public string SourceType { get; set; }
        public string SourceCode { get; set; }
        public string ImportStatus { get; set; }
        public int UpdatedCount { get; set; }
        public int InsertedCount { get; set; }
        public int BlockedCount { get; set; }
        public string Comment { get; set; }
        public System.DateTime LogTime { get; set; }
        public Nullable<int> SourceId { get; set; }
    }
}
