using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DashboardTestApi.Models;
using DevExpress.AspNetCore;
using DevExpress.DashboardAspNetCore;
using DevExpress.DashboardCommon;
using DevExpress.DashboardWeb;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace DashboardTestApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
    /*    public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
        }*/

        public void ConfigureServices(IServiceCollection services)
        {
                services.AddCors(options =>
                {
                    options.AddPolicy(name: "CorsPolicy",
                                      builder =>
                                      {
                                          builder.AllowAnyOrigin()
                 .AllowAnyMethod()
                 .AllowAnyHeader();
                                      });
                })
                //        .AddControllers()
                .AddDevExpressControls()
                .AddControllersWithViews()
                .AddDefaultDashboardController((configurator, serviceProvider) => {
                    configurator.SetConnectionStringsProvider(new DashboardConnectionStringsProvider(Configuration, "Dashboard"));

                    var dataBaseDashboardStorage = new DataBaseEditaleDashboardStorage(
                        Configuration.GetConnectionString("DashboardStorageConnection"));

                    configurator.SetDashboardStorage(dataBaseDashboardStorage);

                    DashboardConfigurator.PassCredentials = true;

             /*       DataSourceInMemoryStorage dataSourceStorage = new DataSourceInMemoryStorage();
                    DashboardObjectDataSource objDataSource = new DashboardObjectDataSource("Object Data Source", typeof(SalesPersonData));

                    objDataSource.DataMember = "GetSalesData";

                    dataSourceStorage.RegisterDataSource("objectDataSource", objDataSource.SaveToXml());

                    configurator.SetDataSourceStorage(dataSourceStorage);*/
                });
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDevExpressControls();
            // Registers routing.
            app.UseRouting();
            // Registers CORS policies.
            app.UseCors("CorsPolicy");
            app.UseEndpoints(endpoints => {
                // Maps the dashboard route.
                EndpointRouteBuilderExtension.MapDashboardRoute(endpoints, "api/dashboard");
                // Requires CORS policies.
           //     endpoints.MapControllers().RequireCors("CorsPolicy");
            });
/*
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

       //     app.UseHttpsRedirection();

            app.UseRouting();

       //     app.UseAuthorization();

            app.UseStaticFiles();
            app.UseDevExpressControls();
            //    app.UseRouting();

            //       app.UseCors("CorsPolicy");
        //    app.UseCors("policy");


            app.UseEndpoints(endpoints => {
                EndpointRouteBuilderExtension.MapDashboardRoute(endpoints, "api/dashboard");
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Dashboard}"
                );
         //       endpoints.MapControllers().RequireCors("CorsPolicy");
            });*/
        }
    }
}
