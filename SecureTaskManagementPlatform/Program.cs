using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using SecureTaskManagementPlatform.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDbContext>(options =>
options.UseInMemoryDatabase("TaskDB"));

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
.AddCookie(options =>
{
options.LoginPath = "/Account/Login";
options.AccessDeniedPath = "/Account/AccessDenied";
options.Cookie.HttpOnly = true;
options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
options.ExpireTimeSpan = TimeSpan.FromMinutes(15);
});

builder.Services.AddAuthorization(options =>
{
options.AddPolicy("CanEditTaskPolicy",
policy => policy.RequireClaim("CanEditTask","true"));
});

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
name:"default",
pattern:"{controller=Home}/{action=Index}/{id?}");

app.Run();