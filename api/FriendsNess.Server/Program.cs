using FriendsNess.Core.Domain.Users;
using FriendsNess.Core.Models;
using FriendsNess.Core.Repositories;
using FriendsNess.Core.Services;
using FriendsNess.Data;
using FriendsNess.Data.Repositories;
using FriendsNess.Server.Extensions;
using FriendsNess.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<FriendsNessDbContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

builder.Services.AddIdentity<ApplicationUser, ApplicationRole>(options =>
{
    options.SignIn.RequireConfirmedAccount = true;
    options.User.RequireUniqueEmail = true;
    options.Password.RequireUppercase = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireDigit = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(1d);
    options.Lockout.MaxFailedAccessAttempts = 5;
    options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789 -._@+/ ‡·ËÈÏÌÛÚ˙˘Á[]{}ø?°!'∑$%&|#~Ä¨<>";
})
.AddEntityFrameworkStores<FriendsNessDbContext>()
.AddDefaultTokenProviders();

builder.Services.AddControllers();

// AÒadir servicios
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();
builder.Services.AddScoped<IExercicesService, ExercicesService>();
builder.Services.AddScoped<IUserExercicesService, UserExercicesService>();
builder.Services.AddScoped<IUsersService, UsersService>();
builder.Services.AddScoped<IExerciceSetsService, ExerciceSetsService>();

builder.Services.Configure<JwtSettings>(builder.Configuration.GetSection("Jwt"));

builder.Services.AddAutoMapper(typeof(Program));

var jwtSettings = builder.Configuration.GetSection("Jwt").Get<JwtSettings>();
builder.Services.AddSingleton(jwtSettings);
builder.Services.AddAuth(jwtSettings);

builder.Services.AddRouting(options => options.LowercaseUrls = true);

builder.Services.AddHttpContextAccessor();

// Configurar polÌtica de seguridad para acceder a FriendsNess
builder.Services.AddCors(opt =>
{
    opt.AddPolicy("FriendsNessPolicy", policy =>
        policy.AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod());
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = "JWT containing userid claim",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
    });
    var security = new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Id = "Bearer",
                    Type = ReferenceType.SecurityScheme
                },
                UnresolvedReference = true
            },
            new List<string>()
        }
    };
    c.AddSecurityRequirement(security);
});

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuth();
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseCors("FriendsNessPolicy");

app.UseAuthorization();

app.MapControllers();

await EnsureDbCreated(app);

app.Run();

/// <summary>
/// Crea la base de datos si es necesario i aplica las migraciones faltantes
/// </summary>
async Task EnsureDbCreated(IApplicationBuilder app)
{
    using var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope();
    var dbContext = serviceScope.ServiceProvider.GetService<FriendsNessDbContext>();
    await dbContext.Database.MigrateAsync();
}