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
    
    public partial class DelegatedUserEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public Nullable<int> ObjectTypeId { get; set; }
        public Nullable<int> ObjectId { get; set; }
        public Nullable<int> SourceUserId { get; set; }
    
        public virtual ObjectTypeEntity ObjectType { get; set; }
        public virtual UserEntity User { get; set; }
        public virtual UserEntity User1 { get; set; }
    }
}
