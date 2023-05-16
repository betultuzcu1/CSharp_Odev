using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MVC_Identity.Models.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//AddIdentity
builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<ProjectContext>();


//AddDbContext
builder.Services.AddDbContext<ProjectContext>(options => options.UseSqlServer("server=DESKTOP-HQIEVQ0\\SQLEXPRESS;database=CodeFirstIdentityDB;uid=sa;pwd=123;"));

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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});

app.Run();
