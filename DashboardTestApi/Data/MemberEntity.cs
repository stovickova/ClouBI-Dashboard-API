using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashboardTestApi.Data
{
    public partial class MemberEntity
    {
        public MemberEntity()
        {
            this.TaskValues = new HashSet<TaskValueEntity>();
            this.MemberRelationsAsChild = new HashSet<MemberRelationEntity>();
            this.MemberRelationsAsParent = new HashSet<MemberRelationEntity>();
            this.FreeFieldValues = new HashSet<FreeFieldValueEntity>();
            this.MemberSetDetails = new HashSet<MemberSetDetailEntity>();
        }

        public int Id { get; set; }
        public int MemberListId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Description { get; set; }
        public double SortOrder { get; set; }
        public bool Imported { get; set; }
        public bool Blocked { get; set; }
        public string Fchar01 { get; set; }
        public string Fchar02 { get; set; }
        public string Fchar03 { get; set; }
        public string Fchar04 { get; set; }
        public string Fchar05 { get; set; }
        public string Fchar06 { get; set; }
        public string Fchar07 { get; set; }
        public string Fchar08 { get; set; }
        public string Fchar09 { get; set; }
        public string Fchar10 { get; set; }
        public Nullable<int> Fint01 { get; set; }
        public Nullable<int> Fint02 { get; set; }
        public Nullable<int> Fint03 { get; set; }
        public Nullable<int> Fint04 { get; set; }
        public Nullable<int> Fint05 { get; set; }
        public Nullable<System.DateTime> Fdate01 { get; set; }
        public Nullable<System.DateTime> Fdate02 { get; set; }
        public Nullable<System.DateTime> Fdate03 { get; set; }
        public Nullable<System.DateTime> Fdate04 { get; set; }
        public Nullable<System.DateTime> Fdate05 { get; set; }
        public Nullable<double> Ffloat01 { get; set; }
        public Nullable<double> Ffloat02 { get; set; }
        public Nullable<double> Ffloat03 { get; set; }
        public Nullable<double> Ffloat04 { get; set; }
        public Nullable<double> Ffloat05 { get; set; }

        public virtual ICollection<TaskValueEntity> TaskValues { get; set; }
        public virtual MemberListEntity MemberList { get; set; }
        public virtual ICollection<MemberRelationEntity> MemberRelationsAsChild { get; set; }
        public virtual ICollection<MemberRelationEntity> MemberRelationsAsParent { get; set; }
        public virtual ICollection<FreeFieldValueEntity> FreeFieldValues { get; set; }
        public virtual ICollection<MemberSetDetailEntity> MemberSetDetails { get; set; }
    }
}
