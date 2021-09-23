using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashboardTestApi.Data
{
    public partial class HierarchyEntity
    {
        public HierarchyEntity()
        {
            this.HierarchyLevels = new HashSet<HierarchyLevelEntity>();
            this.ModelIndicators = new HashSet<ModelIndicatorEntity>();
            this.HierarchySources = new HashSet<HierarchySourceEntity>();
            this.HierarchyLevels1 = new HashSet<HierarchyLevelEntity>();
            this.ModelDimensionalities = new HashSet<ModelDimensionalityEntity>();
        }

        public int Id { get; set; }
        public int DimensionId { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Description { get; set; }
        public bool Imported { get; set; }
        public byte ModuleType { get; set; }
        public int HierarchyTypeId { get; set; }
        public bool AutoRefresh { get; set; }

        public virtual DimensionEntity Dimension { get; set; }
        public virtual ICollection<HierarchyLevelEntity> HierarchyLevels { get; set; }
        public virtual ICollection<ModelIndicatorEntity> ModelIndicators { get; set; }
        public virtual ICollection<HierarchySourceEntity> HierarchySources { get; set; }
        public virtual HierarchyTypeEntity HierarchyType { get; set; }
        public virtual ICollection<HierarchyLevelEntity> HierarchyLevels1 { get; set; }
        public virtual ICollection<ModelDimensionalityEntity> ModelDimensionalities { get; set; }
    }
}
