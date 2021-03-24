using EmployeeMangement.DbContexts;
using EmployeeMangement.Entities;
using EmployeeMangement.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeMangement
{
    public class Startup
    {
        private readonly IConfiguration config;

        public Startup(IConfiguration config)
        {
            this.config = config;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(option => option.EnableEndpointRouting = false);
            services.AddControllersWithViews().AddRazorRuntimeCompilation();
            services.AddScoped<IEmployeeService, SqlEmployeeService>();
            services.AddScoped<IDepartmentService, DepartmentService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddDbContext<AppDbContext>(option => option.UseSqlServer(config.GetConnectionString("DbConnection")));
            services.AddIdentity<AppIdentityUser, AppIdentityRole>().AddEntityFrameworkStores<AppDbContext>();

            //configuration Cookie
            services.AddDistributedMemoryCache();
            services.AddSession(option => {
                option.Cookie.Name = "khoanguyen";
                option.IdleTimeout = new TimeSpan(0, 10, 0);
            });

            services.AddCors();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseSession();
            app.UseCors(option => option.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            //app.UseMvcWithDefaultRoute();
            app.UseMvc(routers =>
            {
                routers.MapRoute(
                        name: "default",
                        template: "{controller=Dashboard}/{action=Index}/{id?}"
                    );
                routers.MapRoute(
                        name: "2ndRouting",
                        template: "{controller=Home}/{action=Login}/{un}/{pw}"
                    );

            });
            
            //app.UseRouting();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        await context.Response.WriteAsync("Hi C1020K1 CodeGym Hue");
            //    });
            //});
        }
    }
}
