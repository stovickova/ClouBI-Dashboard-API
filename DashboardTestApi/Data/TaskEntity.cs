using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashboardTestApi.Data
{
    public partial class TaskEntity
    {
        public TaskEntity()
        {
            this.TaskValues = new HashSet<TaskValueEntity>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public System.DateTime ValidFrom { get; set; }
        public System.DateTime ValidTo { get; set; }
        public System.DateTime ActiveFrom { get; set; }
        public System.DateTime ActiveTo { get; set; }
        public Nullable<int> OutputId { get; set; }
        public int ParentObjectId { get; set; }
        public short ParentType { get; set; }
        public double Weight { get; set; }
        public double StatusWeight { get; set; }
        public double ValueWeight { get; set; }
        public double StatusRedThreshold { get; set; }
        public double ValueRedThreshold { get; set; }
        public bool StatusBiggerBetter { get; set; }
        public bool ValueBiggerBetter { get; set; }

        public virtual OutputEntity Output { get; set; }
        public virtual ICollection<TaskValueEntity> TaskValues { get; set; }
    }
}
