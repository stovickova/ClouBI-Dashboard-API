using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashboardTestApi.Data
{
    public partial class FavoriteOutputEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int OutputId { get; set; }
        public byte Type { get; set; }

        public virtual UserEntity User { get; set; }
    }
}
