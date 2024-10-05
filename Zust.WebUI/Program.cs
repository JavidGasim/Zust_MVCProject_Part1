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
//builder.Services.AddHttpContextAccessor();

builder.Services.AddControllersWithViews();

builder.Services.AddControllersWithViews()
    .AddJsonOptions(opt =>
    {
        opt.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles;
    });

builder.Services.AddScoped<IImageService, ImageService>();
builder.Services.AddScoped<ICustomIdentityUserDAL, CustomIdentityUserDAL>();
builder.Services.AddScoped<ICustomIdentityUserService, CustomIdentityUserService>();
builder.Services.AddScoped<IFriendDAL, FriendDAL>();
builder.Services.AddScoped<IFriendService, FriendService>();
builder.Services.AddScoped<IFriendRequestDAL, FriendRequestDAL>();
builder.Services.AddScoped<IFriendRequestService, FriendRequestService>();
builder.Services.AddScoped<IChatDAL, ChatDAL>();
builder.Services.AddScoped<IChatService, ChatService>();
builder.Services.AddScoped<IMessageDAL, MessageDAL>();
builder.Services.AddScoped<IMessageService, MessageService>();
builder.Services.AddScoped<INotificationDAL, NotificationDAL>();
builder.Services.AddScoped<INotificationService, NotificationService>();
builder.Services.AddScoped<ICommentDAL, CommentDAL>();
builder.Services.AddScoped<ICommentService, CommentService>();
builder.Services.AddScoped<IPostDAL, PostDAL>();
builder.Services.AddScoped<IPostService, PostService>();
builder.Services.AddScoped<ILikedPostDAL, LikedPostDAL>();
builder.Services.AddScoped<ILikedPostService, LikedPostService>();
builder.Services.AddScoped<ILikedCommentDAL, LikedCommentDAL>();
builder.Services.AddScoped<ILikedCommentService, LikedCommentService>();

var connection = builder.Configuration.GetConnectionString("Default");

builder.Services.AddDbContext<ZustDbContext>(options =>
{
    options.UseSqlServer(connection);
});

builder.Services.AddIdentity<CustomIdentityUser, CustomIdentityRole>(options =>
{
    options.Password.RequiredLength = 6;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireDigit = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireLowercase = false;
})
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
    pattern: "{controller=Account}/{action=Login}/{id?}");

app.MapHub<ChatHub>("/chathub");

app.Run();
