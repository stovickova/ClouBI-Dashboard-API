using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashboardTestApi.Data
{
    public partial class UserParameterEntity
    {
        public int Id { get; set; }
        public string ParameterName { get; set; }
        public string ParameterValue { get; set; }
        public int UserId { get; set; }

        public virtual UserEntity User { get; set; }
    }
}
