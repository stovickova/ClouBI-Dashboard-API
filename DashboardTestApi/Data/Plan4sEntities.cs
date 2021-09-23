//using Ambica.Settings;
using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashboardTestApi.Data
{
    public partial class AmbicaBIEntities //: DbContext
    {
   //     public AmbicaBIEntities(string connectionString) : base($"metadata = res://*/EntityFramework.DataModel.csdl|res://*/EntityFramework.DataModel.ssdl|res://*/EntityFramework.DataModel.msl;provider=System.Data.SqlClient;provider connection string='{connectionString}App=EntityFramework'") { }

        private static AmbicaBIEntities sharedContext;
        public static AmbicaBIEntities SharedContext
        {
            get
            {
          /*      if (sharedContext == null)
                {
                    sharedContext = new AmbicaBIEntities(AppSettings.GetConnectionString());
                    sharedContext.Configuration.AutoDetectChangesEnabled = false;
                    //sharedContext.Configuration.LazyLoadingEnabled = false;
                    sharedContext.Database.CommandTimeout = 600;
                }*/
                return sharedContext;
            }
        }

        public static void Refresh()
        {
       /*     if (sharedContext != null)
                sharedContext.Dispose();
            sharedContext = new AmbicaBIEntities(AppSettings.GetConnectionString());*/
        }

        public static void SetContextTimeout(int timeout)
        {
          //  sharedContext.Database.CommandTimeout = timeout;
        }
    }
}
