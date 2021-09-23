using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashboardTestApi.Data
{
    public partial class MemberListRelationEntity
    {
        public MemberListRelationEntity()
        {
            this.ChildMemberListRelations = new HashSet<MemberListRelationEntity>();
            this.MemberRelations = new HashSet<MemberRelationEntity>();
            this.HierarchyLevelsAsChild = new HashSet<HierarchyLevelEntity>();
            this.HierarchyLevelsAsParent = new HashSet<HierarchyLevelEntity>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int ParentListId { get; set; }
        public int ChildListId { get; set; }
        public string Description { get; set; }
        public int RelationTypeId { get; set; }
        public Nullable<int> ParentMemberListRelationId { get; set; }
        public bool Imported { get; set; }
        public bool AutoGenerate { get; set; }

        public virtual ICollection<MemberListRelationEntity> ChildMemberListRelations { get; set; }
        public virtual MemberListRelationEntity ParentMemberListRelation { get; set; }
        public virtual MemberListEntity ChildMemberList { get; set; }
        public virtual MemberListEntity ParentMemberList { get; set; }
        public virtual ICollection<MemberRelationEntity> MemberRelations { get; set; }
        public virtual ICollection<HierarchyLevelEntity> HierarchyLevelsAsChild { get; set; }
        public virtual ICollection<HierarchyLevelEntity> HierarchyLevelsAsParent { get; set; }
    }
}
