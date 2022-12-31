using Microsoft.EntityFrameworkCore;
using MEalAPI.DbContexts;
using Microsoft.AspNetCore.Identity;
using MEalAPI.Entities;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<MealDbContext>(options =>
{
    options.UseNpgsql(connectionString);
});

builder.Services.AddAutoMapper(typeof(Program));

// Add services to the container.
builder.Services.AddControllers();

// Add the user model class to use with Microsoft Identity
builder.Services.AddIdentity<EUser, IdentityRole>(opt =>
{
    // Defaults
    opt.Password.RequireNonAlphanumeric = true;
    opt.Password.RequireUppercase = true;
    opt.User.RequireUniqueEmail = true;
    
    // Overrides
    opt.Password.RequiredLength = 7; // Defaults to 6
}).AddEntityFrameworkStores<MealDbContext>();

builder.Services.ConfigureApplicationCookie(opt => opt.LoginPath = "/account/login");

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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
