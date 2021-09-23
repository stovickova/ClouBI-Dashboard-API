using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashboardTestApi.Data
{
    public partial class MemberListEntity
    {
        public MemberListEntity()
        {
            this.MemberListRelationsAsChild = new HashSet<MemberListRelationEntity>();
            this.MemberListRelationsAsParent = new HashSet<MemberListRelationEntity>();
            this.HierarchyLevels = new HashSet<HierarchyLevelEntity>();
            this.MemberLabels = new HashSet<MemberLabelEntity>();
            this.Members = new HashSet<MemberEntity>();
            this.FreeFields = new HashSet<FreeFieldEntity>();
            this.MemberListFreeFields = new HashSet<MemberListFreeFieldEntity>();
            this.MemberSetDetails = new HashSet<MemberSetDetailEntity>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Description { get; set; }
        public byte ModuleType { get; set; }
        public string AutoCodePrefix { get; set; }
        public Nullable<byte> AutoCodeNumberCount { get; set; }
        public bool GenerateOlapPermissions { get; set; }

        public virtual ICollection<MemberListRelationEntity> MemberListRelationsAsChild { get; set; }
        public virtual ICollection<MemberListRelationEntity> MemberListRelationsAsParent { get; set; }
        public virtual ICollection<HierarchyLevelEntity> HierarchyLevels { get; set; }
        public virtual ICollection<MemberLabelEntity> MemberLabels { get; set; }
        public virtual ICollection<MemberEntity> Members { get; set; }
        public virtual ICollection<FreeFieldEntity> FreeFields { get; set; }
        public virtual ICollection<MemberListFreeFieldEntity> MemberListFreeFields { get; set; }
        public virtual ICollection<MemberSetDetailEntity> MemberSetDetails { get; set; }
    }
}
