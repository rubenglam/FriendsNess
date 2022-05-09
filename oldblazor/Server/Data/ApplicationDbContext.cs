using Duende.IdentityServer.EntityFramework.Entities;
using Duende.IdentityServer.EntityFramework.Options;
using FriendsNess.Shared.Domain.Exercices;
using FriendsNess.Shared.Domain.Users;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace FriendsNess.Server.Data;

public class ApplicationDbContext : KeyApiAuthorizationDbContext<ApplicationUser, ApplicationRole, int>
{
    public ApplicationDbContext(
        DbContextOptions options,
        IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<UserExercice>(x =>
        {
            x.HasKey(x => new { x.UserId, x.ExerciceId });
            x.HasOne(x => x.Exercice)
                .WithMany(x => x.ExerciceUsers)
                .HasForeignKey(x => x.ExerciceId);
            x.HasOne(x => x.User)
                .WithMany(x => x.UserExercices)
                .HasForeignKey(x => x.UserId);
        });

        builder.Seed();
    }

    public DbSet<Exercice> Exercices { get; set; }
    public DbSet<UserExercice> UserExercices { get; set; }
}
