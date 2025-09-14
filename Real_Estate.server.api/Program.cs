using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Real_Estate.server.api.Data;
using Real_Estate.server.api.Models;
using Real_Estate.server.api.services.Implementations;
using Real_Estate.server.api.services.Interfaces;
using Serilog;
using System.Runtime.InteropServices;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontendApp", policy =>
    {
        policy.WithOrigins(
            "http://localhost:4200",

            "http://primehousingraj.com",
            "https://primehousingraj.com",
            "https://www.primehousingraj.com"

        //"http://triconproperty.com",
        //"https://triconproperty.com",
        //"https://www.triconproperty.com" 
        )
        .AllowAnyHeader()
        .AllowAnyMethod()
        .AllowCredentials();
    });
});

// Configure Serilog
void ConfigureLog()
{
    try
    {
        var logdir = RuntimeInformation.IsOSPlatform(OSPlatform.Linux)
            ? $"logs/log-{DateTime.Now:yyyyMMdd}.log"
            : $"logs\\log-{DateTime.Now:yyyyMMdd}.log";
        var logPath = Environment.CurrentDirectory;
        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Warning()
            .Enrich.FromLogContext()
            .WriteTo.File(
                Path.Combine(logPath, logdir),
                Serilog.Events.LogEventLevel.Warning,
                outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level}] ({SourceContext}.{Method}) {Message}{NewLine}{Exception}",
                retainedFileCountLimit: 31)
            .CreateLogger();

        Log.Logger.Warning("Application starting...");
        Log.Logger.Warning($"Log path: {Path.Combine(logPath, logdir)}");
    }
    catch (Exception e)
    {
        Console.WriteLine($"Failed to configure logging: {e.Message}");
    }
}
ConfigureLog();

// Add services to the container
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default"), opt =>
    {
        opt.CommandTimeout((int)TimeSpan.FromMinutes(5).TotalSeconds);
        opt.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery);
    }));

builder.Services.AddIdentity<ApplicationUser, ApplicationRole>(options =>
{
    options.Stores.MaxLengthForKeys = 128;
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequiredLength = 6;
    options.Password.RequiredUniqueChars = 1;
    options.SignIn.RequireConfirmedEmail = true;
    options.Lockout.MaxFailedAccessAttempts = 5;
    options.Lockout.AllowedForNewUsers = true;
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(10);
})
.AddDefaultTokenProviders()
.AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddScoped<IDbInitializer, DbInitializer>();
builder.Services.AddScoped<IFaqServices, FaqRepository>();

builder.Services.AddSerilog();

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        ValidAudience = builder.Configuration["Jwt:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
    };
});




builder.Services.AddControllers();
builder.Services.AddOpenApi();

var app = builder.Build();

// Seed data
using (var scope = app.Services.CreateScope())
{
    try
    {
        var service = scope.ServiceProvider.GetRequiredService<IDbInitializer>();
        await service.InitializeDB();
        await service.InitializeRoles();
        await service.InitializeUsers();
        //await service.SeedProjects();
    }
    catch (Exception ex)
    {
        Log.Logger.Error($"Failed to seed data: {ex.Message}");
    }
}


// Add CORS middleware here BEFORE UseAuthorization and UseAuthentication
app.UseCors("AllowFrontendApp");
// Configure the HTTP request pipeline
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

app.Run();
