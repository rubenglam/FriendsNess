using Duende.IdentityServer.EntityFramework.Entities;
using Duende.IdentityServer.EntityFramework.Options;
using FriendsNess.Core.Domain.Exercices;
using FriendsNess.Core.Domain.Planning;
using FriendsNess.Core.Domain.Users;
using FriendsNess.Data.Base;
using FriendsNess.Data.Extensions;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace FriendsNess.Data;

public class FriendsNessDbContext : KeyApiAuthorizationDbContext<ApplicationUser, ApplicationRole, int>
{
    public FriendsNessDbContext(
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
                .WithMany(x => x.UsersExercices)
                .HasForeignKey(x => x.ExerciceId);
            x.HasOne(x => x.User)
                .WithMany(x => x.UsersExercices)
                .HasForeignKey(x => x.UserId);
        });

        builder.Seed();
    }

    public DbSet<Exercice> Exercices { get; set; }
    public DbSet<UserExercice> UserExercices { get; set; }
    public DbSet<ExerciceSet> ExerciceSets { get; set; }
    public DbSet<Planning> Plannings { get; set; }
    public DbSet<PlanningExerciceSet> PlanningExerciceSets { get; set; }
}
