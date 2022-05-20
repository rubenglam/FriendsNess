using FriendsNess.Core.Domain.Exercices;
using FriendsNess.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FriendsNess.Data.Repositories;

public class ExercicesRepository : Repository<Exercice>, IExercicesRepository
{
    public ExercicesRepository(FriendsNessDbContext dbContext) : base(dbContext)
    {
    }

    public IQueryable<Exercice> GetAll()
    {
        return DbContext.Exercices;
    }

    public async Task<Exercice> Get(int id)
    {
        return await GetAll().FirstOrDefaultAsync(x => x.Id == id);
    }
}
