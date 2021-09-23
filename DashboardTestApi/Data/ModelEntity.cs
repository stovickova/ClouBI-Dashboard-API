using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashboardTestApi.Data
{
    public partial class ModelEntity
    {
        public ModelEntity()
        {
            this.Meetings = new HashSet<MeetingEntity>();
            this.MemberSetFacts = new HashSet<MemberSetFactEntity>();
            this.MemberSets = new HashSet<MemberSetEntity>();
            this.ModelDefaultValueTypes = new HashSet<ModelDefaultValueTypeEntity>();
            this.ModelDimensionalities = new HashSet<ModelDimensionalityEntity>();
            this.ModelIndicators = new HashSet<ModelIndicatorEntity>();
            this.ModelReports = new HashSet<ModelReportEntity>();
            this.Workflows = new HashSet<WorkflowEntity>();
            this.WorkflowStepDetails = new HashSet<WorkflowStepDetailEntity>();
            this.WorkflowSteps = new HashSet<WorkflowStepEntity>();
            this.ModelValueSources = new HashSet<ModelValueSourceEntity>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int StatusId { get; set; }
        public Nullable<System.DateTime> ClosedToDate { get; set; }
        public bool ReadyForCube { get; set; }
        public string CubeName { get; set; }
        public byte ModuleType { get; set; }
        public int BscType { get; set; }
        public bool DistinctCountIncluding { get; set; }

        public virtual ICollection<MeetingEntity> Meetings { get; set; }
        public virtual ICollection<MemberSetFactEntity> MemberSetFacts { get; set; }
        public virtual ICollection<MemberSetEntity> MemberSets { get; set; }
        public virtual ICollection<ModelDefaultValueTypeEntity> ModelDefaultValueTypes { get; set; }
        public virtual ICollection<ModelDimensionalityEntity> ModelDimensionalities { get; set; }
        public virtual ICollection<ModelIndicatorEntity> ModelIndicators { get; set; }
        public virtual ICollection<ModelReportEntity> ModelReports { get; set; }
        public virtual ICollection<WorkflowEntity> Workflows { get; set; }
        public virtual ICollection<WorkflowStepDetailEntity> WorkflowStepDetails { get; set; }
        public virtual ICollection<WorkflowStepEntity> WorkflowSteps { get; set; }
        public virtual ICollection<ModelValueSourceEntity> ModelValueSources { get; set; }
    }
}
