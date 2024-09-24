using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Zust.Business.Services.Abstracts;
using Zust.Business.Services.Concretes;
using Zust.DataAccess.Data;
using Zust.DataAccess.Repositories.Abstracts;
using Zust.DataAccess.Repositories.Concretes;
using Zust.Entities.Entities;
using Zust.WebUI.Hubs;
using Zust.WebUI.Services.Abstracts;
using Zust.WebUI.Services.Concretes;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IImageService, ImageService>();
builder.Services.AddScoped<ICustomIdentityUserDAL, CustomIdentityUserDAL>();
builder.Services.AddScoped<ICustomIdentityUserService, CustomIdentityUserService>();

var connection = builder.Configuration.GetConnectionString("Default");

builder.Services.AddDbContext<ZustDbContext>(options =>
{
    options.UseSqlServer(connection);
});

builder.Services.AddIdentity<CustomIdentityUser, CustomIdentityRole>()
    .AddEntityFrameworkStores<ZustDbContext>()
    .AddDefaultTokenProviders();

builder.Services.AddSignalR();

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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapHub<ChatHub>("/chathub");

app.Run();
