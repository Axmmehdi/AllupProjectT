using AllupProjectT.DataAccessLayer;
using AllupProjectT.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(options =>
                 options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));


builder.Services.AddScoped<LayoutService>();
//builder.Services.AddTransient<>
//builder.Services.AddSingleton<>
//builder.Services.AddScoped<>

var app = builder.Build();
app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
app.UseStaticFiles();
app.Run();
