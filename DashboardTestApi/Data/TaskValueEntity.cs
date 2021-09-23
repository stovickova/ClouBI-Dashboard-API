using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashboardTestApi.Data
{
    public partial class TaskValueEntity
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public int TaskId { get; set; }
        public System.DateTime Date { get; set; }
        public string Name { get; set; }
        public Nullable<int> OutputId { get; set; }
        public string Description { get; set; }
        public Nullable<double> ActualValue { get; set; }
        public Nullable<double> ActualStatus { get; set; }
        public Nullable<double> PlanValue { get; set; }
        public Nullable<double> PlanStatus { get; set; }

        public virtual TaskEntity Task { get; set; }
        public virtual MemberEntity Member { get; set; }
    }
}
