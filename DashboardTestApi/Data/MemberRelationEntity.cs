using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashboardTestApi.Data
{
    public partial class MemberRelationEntity
    {
        public MemberRelationEntity()
        {
            this.ChildMemberRelations = new HashSet<MemberRelationEntity>();
        }

        public long Id { get; set; }
        public int MemberListRelationId { get; set; }
        public int ParentMemberId { get; set; }
        public int ChildMemberId { get; set; }
        public int SortOrder { get; set; }
        public bool Imported { get; set; }
        public Nullable<long> MtMParentMemberId { get; set; }
        public virtual ICollection<MemberRelationEntity> ChildMemberRelations { get; set; }
        public virtual MemberRelationEntity ParentMemberRelation { get; set; }
        public virtual MemberListRelationEntity MemberListRelation { get; set; }
        public virtual MemberEntity ChildMember { get; set; }
        public virtual MemberEntity ParentMember { get; set; }
    }
}
