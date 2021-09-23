using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashboardTestApi.Data
{
    public partial class UserEntity
    {
        public UserEntity()
        {
            this.FavoriteOutputs = new HashSet<FavoriteOutputEntity>();
            this.Outputs = new HashSet<OutputEntity>();
            this.Outputs1 = new HashSet<OutputEntity>();
            this.OutputXmls = new HashSet<OutputXmlEntity>();
            this.UserParameters = new HashSet<UserParameterEntity>();
            this.DelegatedUsers = new HashSet<DelegatedUserEntity>();
            this.DelegatedUsers1 = new HashSet<DelegatedUserEntity>();
            this.Licences = new HashSet<LicenceEntity>();
            this.UserGroups = new HashSet<UserGroupEntity>();
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Domain { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public string Password { get; set; }
        public bool WA { get; set; }

        public virtual ICollection<FavoriteOutputEntity> FavoriteOutputs { get; set; }
        public virtual ICollection<OutputEntity> Outputs { get; set; }
        public virtual ICollection<OutputEntity> Outputs1 { get; set; }
        public virtual ICollection<OutputXmlEntity> OutputXmls { get; set; }
        public virtual ICollection<UserParameterEntity> UserParameters { get; set; }
        public virtual ICollection<DelegatedUserEntity> DelegatedUsers { get; set; }
        public virtual ICollection<DelegatedUserEntity> DelegatedUsers1 { get; set; }
        public virtual ICollection<LicenceEntity> Licences { get; set; }
        public virtual ICollection<UserGroupEntity> UserGroups { get; set; }
    }
}
