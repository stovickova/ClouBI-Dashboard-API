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
    
    public partial class MemberSetDetailEntity
    {
        public long Id { get; set; }
        public long MemberSetId { get; set; }
        public int MemberListId { get; set; }
        public int MemberId { get; set; }
    
        public virtual MemberListEntity MemberList { get; set; }
        public virtual MemberEntity Member { get; set; }
        public virtual MemberSetEntity MemberSet { get; set; }
    }
}