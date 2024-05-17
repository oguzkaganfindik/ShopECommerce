using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.EntityFrameworkCore;
using ShopECommerce.Business;
using ShopECommerce.Data.Context;
using ShopECommerce.WebUI.Services.Abstract;
using ShopECommerce.WebUI.Services.Concrete;
using System.Security.Claims;

var builder = WebApplication.CreateBuilder(args);

var configuration = builder.Configuration;

builder.Configuration
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddJsonFile("appsettings.EmailSettings.json", optional: true, reloadOnChange: true);

builder.Services.AddControllersWithViews();

builder.Services.AddMappingRegistration();

builder.Services.AddServicesRegistration();

builder.Services.AddScoped<IImageProcessingService, ImageProcessingManager>();
builder.Services.AddScoped<IImageService, ImageManager>();
builder.Services.AddScoped<IEmailService, EmailService>();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ShopECommerceContext>(options => options.UseSqlServer(connectionString));

var serviceProvider = builder.Services.BuildServiceProvider();

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
    .AddCookie("SuperAdmin", options =>
    {
        options.LoginPath = "/Auth/Login/";
        options.AccessDeniedPath = "/AccessDenied/";
        options.LogoutPath = "/Auth/LogOut/";
        options.Cookie.Name = "SuperAdmin";
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
    options.AddPolicy("SuperAdminPolicy", policy => policy.RequireClaim(ClaimTypes.Role, "SuperAdmin"));
    options.AddPolicy("AdminPolicy", policy => policy.RequireClaim(ClaimTypes.Role, "SuperAdmin", "Admin"));
    options.AddPolicy("UserPolicy", policy => policy.RequireClaim(ClaimTypes.Role, "SuperAdmin", "Admin", "User"));
    options.AddPolicy("CustomerPolicy", policy => policy.RequireClaim(ClaimTypes.Role, "SuperAdmin", "Admin", "User", "Customer"));
});


// Add services to the container.
builder.Services.AddHttpClient();

var contentrootPath = builder.Environment.ContentRootPath;
var keysDirectory = new DirectoryInfo(Path.Combine(contentrootPath, "App_Data", "Keys"));

builder.Services.AddDataProtection()
    .SetApplicationName("ShopECommerce")
    .SetDefaultKeyLifetime(new TimeSpan(99999, 0, 0))
    .PersistKeysToFileSystem(keysDirectory);

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var dbContext = services.GetRequiredService<ShopECommerceContext>();

    dbContext.Database.EnsureCreated();
    dbContext.Database.Migrate();
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("AccessDenied");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

//app.UseStatusCodePagesWithRedirects("AccessDenied");

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Statistic}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Default}/{action=Index}/{id?}");

app.Run();
