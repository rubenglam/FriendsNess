using FriendsNess.Core.Domain.Exercices;
using Microsoft.EntityFrameworkCore;

namespace FriendsNess.Data.Extensions;

public static class ModelBuilderExtensions
{
    private static readonly IEnumerable<Exercice> _exercices = new List<Exercice>()
    {
        
    };

    public static void Seed(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Exercice>().HasData(_exercices);
    }
}
