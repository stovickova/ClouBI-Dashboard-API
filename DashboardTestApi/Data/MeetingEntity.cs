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
    
    public partial class MeetingEntity
    {
        public int Id { get; set; }
        public int TimeId { get; set; }
        public string Text { get; set; }
        public int ModelId { get; set; }
    
        public virtual TimeMemberEntity TimeMember { get; set; }
        public virtual ModelEntity Model { get; set; }
    }
}
