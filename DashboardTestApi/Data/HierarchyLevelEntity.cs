using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashboardTestApi.Data
{
    public partial class HierarchyLevelEntity
    {
        public HierarchyLevelEntity()
        {
            this.ModelIndicatorDetailLevels = new HashSet<ModelIndicatorDetailLevelEntity>();
            this.ModelSharingDimensionalities = new HashSet<ModelSharingDimensionalityEntity>();
            this.ModelIndicatorValueSources = new HashSet<ModelIndicatorValueSourceEntity>();
            this.ModelIndicatorValueSourceDimLevels = new HashSet<ModelIndicatorValueSourceDimLevelEntity>();
            this.ModelValueSourceDimLevels = new HashSet<ModelValueSourceDimLevelEntity>();
            this.HierarchySources = new HashSet<HierarchySourceEntity>();
            this.HierarchySources1 = new HashSet<HierarchySourceEntity>();
            this.ModelDimensionalities = new HashSet<ModelDimensionalityEntity>();
            this.ModelValueSources = new HashSet<ModelValueSourceEntity>();
        }

        public int Id { get; set; }
        public int HierarchyId { get; set; }
        public int LevelOrdinal { get; set; }
        public string Name { get; set; }
        public int MemberListId { get; set; }
        public Nullable<int> UpMemberListRelationId { get; set; }
        public Nullable<int> DownMemberListRelationId { get; set; }
        public bool IsManyToMany { get; set; }
        public byte ModuleType { get; set; }
        public Nullable<int> TreeHierarchyId { get; set; }

        public virtual HierarchyEntity Hierarchy { get; set; }
        public virtual MemberListRelationEntity DownMemberListRelation { get; set; }
        public virtual MemberListRelationEntity UpMemberListRelation { get; set; }
        public virtual MemberListEntity MemberList { get; set; }
        public virtual ICollection<ModelIndicatorDetailLevelEntity> ModelIndicatorDetailLevels { get; set; }
        public virtual ICollection<ModelSharingDimensionalityEntity> ModelSharingDimensionalities { get; set; }
        public virtual ICollection<ModelIndicatorValueSourceEntity> ModelIndicatorValueSources { get; set; }
        public virtual ICollection<ModelIndicatorValueSourceDimLevelEntity> ModelIndicatorValueSourceDimLevels { get; set; }
        public virtual ICollection<ModelValueSourceDimLevelEntity> ModelValueSourceDimLevels { get; set; }
        public virtual ICollection<HierarchySourceEntity> HierarchySources { get; set; }
        public virtual ICollection<HierarchySourceEntity> HierarchySources1 { get; set; }
        public virtual HierarchyEntity Hierarchy1 { get; set; }
        public virtual ICollection<ModelDimensionalityEntity> ModelDimensionalities { get; set; }
        public virtual ICollection<ModelValueSourceEntity> ModelValueSources { get; set; }
    }
}
