using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using RealHouzing.Consume.Models;
using RealHouzing.Consume.ViewComponents.Default;
using RealHouzing.DataAccessLayer.Concrete;
using RealHouzing.EntityLayer.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<Context>();
builder.Services.AddControllersWithViews();
builder.Services.AddHttpClient();
builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<Context>();



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
app.UseAuthentication();
app.UseAuthorization();
 // Yetkilendirme kullanýmý


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Default}/{action=Index}/{id?}");

app.Run();

app.UseStaticFiles();


