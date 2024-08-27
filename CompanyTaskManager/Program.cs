using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PolcarZadanie.Data;
using PolcarZadanie.DbServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, opt => builder.Configuration.Bind(opt));

builder.Services.AddScoped<IWorkTasksDbService, WorkTasksDbService>();
builder.Services.AddTransient<IEmployeesDbService, EmployeesDbService>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.Configure<IdentityOptions>(opt =>
{
    opt.Password.RequireNonAlphanumeric = false;
    opt.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromSeconds(15);
    opt.Lockout.MaxFailedAccessAttempts = 5;
    opt.User.RequireUniqueEmail = true;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();
app.UseAuthentication();
app.MapControllers();

using var scope = app.Services.CreateScope();
var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();
try
{
    var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    context.Database.Migrate();
    using var seeder = new DataSeeder(context);
    await seeder.Seed();
}
catch (Exception ex)
{
    logger.LogError(ex, "Database error");
}

app.Run();
