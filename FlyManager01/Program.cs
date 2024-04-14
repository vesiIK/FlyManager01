using FlyManager01.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using FlyManager01.Models;

namespace FlyManager01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
                        var connectionString = builder.Configuration.GetConnectionString("FlyManager01ContextConnection") ?? throw new InvalidOperationException("Connection string 'FlyManager01ContextConnection' not found.");

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            //builder.Services.AddDbContext<FlyManagerData>(options =>
            //{
            //    options.UseSqlServer("Server=DESKTOP-8TSUA0S\\SQLEXPRESS; Database=TestFlyManager; Integrated Security=true; TrustServerCertificate=True");
            //});

            builder.Services.AddDbContext<FlyManagerData>(options => options.UseSqlServer("Server=DESKTOP-8TSUA0S\\SQLEXPRESS; Database=TestFlyManager; Integrated Security=true; TrustServerCertificate=True"));
            builder.Services.AddIdentity<AccountsUser, IdentityRole>().AddEntityFrameworkStores<FlyManagerData>().AddDefaultTokenProviders();
            builder.Services.Configure<DataProtectionTokenProviderOptions>(opts => opts.TokenLifespan = TimeSpan.FromHours(10));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();
                        app.UseAuthentication();;

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");


            app.Run();
        }
    }
}