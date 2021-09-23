using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashboardTestApi.Data
{

    public partial class OutputEntity
    {
        public OutputEntity()
        {
            this.Outputs1 = new HashSet<OutputEntity>();
            this.FavoriteOutputs = new HashSet<FavoriteOutputEntity>();
            this.Tasks = new HashSet<TaskEntity>();
            this.OutputXmls = new HashSet<OutputXmlEntity>();
            this.Actions = new HashSet<ActionEntity>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int OwnerId { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> ModifiedById { get; set; }
        public string XmlData { get; set; }
        public byte Type { get; set; }
        public Nullable<int> ParentId { get; set; }
        public Nullable<int> Version { get; set; }
        public byte Permission { get; set; }
        public string Image { get; set; }
        public Nullable<int> DemoTypeId { get; set; }
        public byte ModuleType { get; set; }
        public string SubType { get; set; }
        public bool Link { get; set; }

        public virtual ICollection<OutputEntity> Outputs1 { get; set; }
        public virtual OutputEntity Output1 { get; set; }
        public virtual ICollection<FavoriteOutputEntity> FavoriteOutputs { get; set; }
        public virtual ICollection<TaskEntity> Tasks { get; set; }
        public virtual ICollection<OutputXmlEntity> OutputXmls { get; set; }
        public virtual ICollection<ActionEntity> Actions { get; set; }
        public virtual UserEntity User { get; set; }
        public virtual UserEntity User1 { get; set; }
    }
}
