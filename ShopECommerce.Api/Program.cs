using Microsoft.AspNetCore.DataProtection;
using Microsoft.EntityFrameworkCore;
using ShopECommerce.Api.Hubs;
using ShopECommerce.Business;
using ShopECommerce.Data.Context;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(opt =>
{
    opt.AddPolicy("CorsPolicy", builder =>
    {
        builder.AllowAnyHeader()
        .AllowAnyMethod()
        .SetIsOriginAllowed((host) => true)
        .AllowCredentials();
    });
});

builder.Services.AddSignalR();

// Add services to the container.
builder.Services.AddServicesRegistration();

builder.Services.AddMappingRegistration();


builder.Services.AddControllersWithViews()
    .AddJsonOptions(options => options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

builder.Services.AddControllers();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<ShopECommerceContext>(options => options.UseSqlServer(connectionString));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var contentrootPath = builder.Environment.ContentRootPath;
var keysDirectory = new DirectoryInfo(Path.Combine(contentrootPath, "App_Data", "Keys"));

builder.Services.AddDataProtection()
    .SetApplicationName("ShopECommerce")
    .SetDefaultKeyLifetime(new TimeSpan(99999, 0, 0))
    .PersistKeysToFileSystem(keysDirectory);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("CorsPolicy");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapHub<SignalRHub>("/signalrhub");

app.Run();
