using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashboardTestApi.Data
{
    public partial class OutputXmlEntity
    {
        public int Id { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> OutputId { get; set; }
        public string XmlData { get; set; }
        public byte OutputType { get; set; }
        public byte XmlType { get; set; }
        public byte[] File { get; set; }

        public virtual OutputEntity Output { get; set; }
        public virtual UserEntity User { get; set; }

    }
}
