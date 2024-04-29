using Microsoft.AspNetCore.DataProtection;
using Microsoft.EntityFrameworkCore;
using ShopECommerce.Data.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var connectionString = builder.Configuration.GetConnectionString
    ("DefaultConnection");

builder.Services.AddDbContext<ShopECommerceContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddControllers();

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
