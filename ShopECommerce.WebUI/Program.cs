using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using ShopECommerce.Business;
using ShopECommerce.Data.Context;
using ShopECommerce.WebUI.Services.Abstract;
using ShopECommerce.WebUI.Services.Concrete;
using System.Security.Claims;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ShopECommerceContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddServicesRegistration();
builder.Services.AddMappingRegistration();

builder.Services.AddScoped<IImageProcessingService, ImageProcessingManager>();
builder.Services.AddScoped<IImageService, ImageManager>();
builder.Services.AddScoped<IEmailService, EmailService>();

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    options.DefaultSignOutScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    options.DefaultForbidScheme = CookieAuthenticationDefaults.AuthenticationScheme;
})
    .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme, options =>
    {
        options.LoginPath = "/Auth/Login/";
        options.AccessDeniedPath = "/AccessDenied/";
        options.LogoutPath = "/Auth/LogOut/";
        options.Cookie.Name = "ShopECommerce";
        options.Cookie.MaxAge = TimeSpan.FromDays(1);
        options.Cookie.IsEssential = true;
    })
    .AddCookie("Admin", options =>
    {
        options.LoginPath = "/Auth/Login/";
        options.AccessDeniedPath = "/AccessDenied/";
        options.LogoutPath = "/Auth/LogOut/";
        options.Cookie.Name = "Admin";
        options.Cookie.MaxAge = TimeSpan.FromDays(1);
        options.Cookie.IsEssential = true;
    })
    .AddCookie("User", options =>
    {
        options.LoginPath = "/Auth/Login/";
        options.AccessDeniedPath = "/AccessDenied/";
        options.LogoutPath = "/Auth/LogOut/";
        options.Cookie.Name = "User";
        options.Cookie.MaxAge = TimeSpan.FromDays(1);
        options.Cookie.IsEssential = true;
    })
    .AddCookie("Customer", options =>
    {
        options.LoginPath = "/Auth/Login/";
        options.AccessDeniedPath = "/AccessDenied/";
        options.LogoutPath = "/Auth/LogOut/";
        options.Cookie.Name = "Customer";
        options.Cookie.MaxAge = TimeSpan.FromDays(1);
        options.Cookie.IsEssential = true;
    });

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("AdminPolicy", policy => policy.RequireClaim(ClaimTypes.Role, "Admin"));
    options.AddPolicy("UserPolicy", policy => policy.RequireClaim(ClaimTypes.Role, "Admin", "User"));
    options.AddPolicy("CustomerPolicy", policy => policy.RequireClaim(ClaimTypes.Role, "Admin", "User", "Customer"));
});

// Add services to the container.
builder.Services.AddHttpClient();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("AccessDenied");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Default}/{action=Index}/{id?}");

app.Run();
