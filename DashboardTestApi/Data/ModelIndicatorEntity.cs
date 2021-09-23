using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashboardTestApi.Data
{
    public partial class ModelIndicatorEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ModelIndicatorEntity()
        {
            this.ModelIndicatorValueTypes = new HashSet<ModelIndicatorValueTypeEntity>();
            this.ModelIndicatorDetailLevels = new HashSet<ModelIndicatorDetailLevelEntity>();
            this.ModelSharingDimensionalities = new HashSet<ModelSharingDimensionalityEntity>();
            this.ModelIndicatorValueSources = new HashSet<ModelIndicatorValueSourceEntity>();
        }

        public int Id { get; set; }
        public int ModelId { get; set; }
        public int IndicatorId { get; set; }
        public int TimeHierarchyId { get; set; }
        public int HierarchyId { get; set; }

        public virtual HierarchyEntity Hierarchy { get; set; }
        public virtual IndicatorEntity Indicator { get; set; }
        public virtual TimeHierarchyEntity TimeHierarchy { get; set; }
        public virtual ICollection<ModelIndicatorValueTypeEntity> ModelIndicatorValueTypes { get; set; }
        public virtual ICollection<ModelIndicatorDetailLevelEntity> ModelIndicatorDetailLevels { get; set; }
        public virtual ICollection<ModelSharingDimensionalityEntity> ModelSharingDimensionalities { get; set; }
        public virtual ICollection<ModelIndicatorValueSourceEntity> ModelIndicatorValueSources { get; set; }
        public virtual ModelEntity Model { get; set; }
    }
}
