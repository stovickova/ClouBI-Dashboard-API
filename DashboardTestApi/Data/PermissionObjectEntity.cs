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
    
    public partial class PermissionObjectEntity
    {
        public int Id { get; set; }
        public int UserGroupId { get; set; }
        public int RolePermissionId { get; set; }
        public Nullable<int> ObjectTypeId { get; set; }
        public Nullable<long> ObjectId { get; set; }
        public Nullable<bool> IsRestrictedPermission { get; set; }
    }
}
