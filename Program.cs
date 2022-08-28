using Microsoft.EntityFrameworkCore;
using MEalAPI.DbContexts;
using MEalAPI.Models;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

var connectionString = "Host=localhost; Port=5432; Database=MEal; Username=postgres; Password=postgres";

// Add services to the container.
builder.Services.AddControllers();

builder.Services.AddDbContext<MEalDbContext>(options =>
{
    options.UseNpgsql(connectionString);
});

builder.Services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<MEalDbContext>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
