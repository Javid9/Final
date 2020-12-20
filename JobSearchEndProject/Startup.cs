using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using JobSearchEndProject.DAL;
using JobSearchEndProject.Models;
using JobSearchEndProject.Services.Mapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace JobSearchEndProject
{
    public class Startup
    {

        private readonly IConfiguration _conviguration;
        public Startup(IConfiguration conviguration)
        {
            _conviguration = conviguration;
        }


        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<AppDbContext>(option =>
            {
                option.UseSqlServer(_conviguration["ConnectionString:Default"]);
            });

            services.AddIdentity<AppUser, IdentityRole>(identityOption =>
             {
                 identityOption.Password.RequiredLength = 7;
                 identityOption.Password.RequireNonAlphanumeric = true;
                 identityOption.Password.RequireLowercase = true;
                 identityOption.Password.RequireUppercase = true;
                 identityOption.Password.RequireDigit = true;

                 identityOption.User.RequireUniqueEmail = true;

                 identityOption.Lockout.MaxFailedAccessAttempts = 5;
                 identityOption.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                 identityOption.Lockout.AllowedForNewUsers = true;
             }).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();
            services.AddAutoMapper(typeof(MappingProfile));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStatusCodePagesWithReExecute("/ErrorPage/Index/");

          
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                name: "areas",
                pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}");
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");


                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

            });

        }
    }
}
