using FriendsNess.Core.Domain.Users;
using FriendsNess.Server.Data;
using FriendsNess.Server.Services.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

builder.Services.AddDefaultIdentity<ApplicationUser>(options =>
{
    options.SignIn.RequireConfirmedAccount = true;
    options.User.RequireUniqueEmail = true;
    options.Password.RequireUppercase = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireDigit = false;
    options.Password.RequireNonAlphanumeric = false;
    options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789 -._@+/ �����������[]{}�?�!'�$%&|#~��<>";
})
    .AddRoles<ApplicationRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddControllers();

// A�adir servicios
builder.Services.AddScoped<IUnitOfRepositories, UnitOfRepositories>();

builder.Services.AddHttpContextAccessor();

// Configurar pol�tica de seguridad para acceder a FriendsNess
builder.Services.AddCors(opt =>
{
    opt.AddPolicy("FriendsNessPolicy", policy =>
        policy.AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod());
});

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
    var dbContext = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();
    await dbContext.Database.MigrateAsync();
}