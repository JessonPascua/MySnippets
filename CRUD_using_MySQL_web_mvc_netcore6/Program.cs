using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CRUD_using_MySQL_web_mvc_netcore6.Data;
using System.Configuration;

namespace CRUD_using_MySQL_web_mvc_netcore6
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var connectionString = builder.Configuration.GetConnectionString("HealthCareDbContext") ?? throw new InvalidOperationException("Connection string 'HealthCareDbContext' not found.");
            builder.Services.AddDbContext<HealthCareDbContext>(options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

            // For specific version on MySql.
            //builder.Services.AddDbContext<HealthCareDbContext>(options => options.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 33))));

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            else
            {
                //Seeding initial data.
                await SeedData.MySeedData(app);
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}