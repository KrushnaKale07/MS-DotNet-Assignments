using Microsoft.EntityFrameworkCore;
using WebApplDay9.DAO;
using WebApplDay9.Data;
using WebApplDay9.Services;

namespace WebApplDay9
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddDbContext<Day9DbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("MySQLConn")));

            builder.Services.AddScoped<IBookService, BookService>();
            builder.Services.AddScoped<IUserDAO, UserDAO>();

            builder.Services.AddControllersWithViews();
            builder.Services.AddSession(option => { 
                option.IdleTimeout = TimeSpan.FromSeconds(30);
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseSession();

            app.UseAuthentication();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
