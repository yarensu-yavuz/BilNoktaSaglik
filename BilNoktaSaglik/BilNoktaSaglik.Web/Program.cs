using BilNoktaSaglik.Repository;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace BilNoktaSaglik.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();


            builder.Services.AddDbContext<BilNoktaSaglikDB>(k =>
            {

                k.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"), option =>
                {
                    option.MigrationsAssembly(Assembly.GetAssembly(typeof(BilNoktaSaglikDB)).GetName().Name);
                });
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapAreaControllerRoute(
                  name: "areas",
                  areaName: "AdminPanel",
                  pattern: "AdminPanel/{controller=Home}/{action=LayoutPageIndex}/{id?}"
                );

                app.MapControllerRoute(
              name: "default",
              pattern: "{controller=Home}/{action=HomeIndex}/{id?}");

            });
            app.Run();
        }
    }
}