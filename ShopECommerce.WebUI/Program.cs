using ShopECommerce.Data.Context;
using ShopECommerce.WebUI.Services.Abstract;
using ShopECommerce.WebUI.Services.Concrete;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ShopECommerceContext>();

builder.Services.AddScoped<IImageProcessingService, ImageProcessingManager>();
builder.Services.AddScoped<IImageService, ImageManager>();

// Add services to the container.
builder.Services.AddHttpClient();

builder.Services.AddControllersWithViews();

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
    name: "areas",
    pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Default}/{action=Index}/{id?}");

app.Run();
