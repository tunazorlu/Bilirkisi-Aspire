using BilirkisiAspire.ApiService.Data;
using BilirkisiAspire.Shared.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add service defaults & Aspire components.
builder.AddServiceDefaults();

// Add services to the container.
builder.Services.AddProblemDetails();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddIdentity<AppUser, AppUserRole>()
    .AddEntityFrameworkStores<AppDbContext>()
    .AddDefaultTokenProviders();

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("SQLDbConnection"));
});

builder.Services.AddAuthorization();

/*builder.Services.AddIdentityApiEndpoints<AppUser>()
    .AddEntityFrameworkStores<AppDbContext>()
    .AddDefaultTokenProviders();*/

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseExceptionHandler();

/*app.MapIdentityApi<AppUser>();*/

app.UseHttpsRedirection();
app.MapDefaultEndpoints();

app.UseAuthorization();

app.MapControllers();

app.Run();