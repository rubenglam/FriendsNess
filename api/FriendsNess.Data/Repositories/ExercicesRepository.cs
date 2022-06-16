using FriendsNess.Core.Domain.Exercices;
using FriendsNess.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FriendsNess.Data.Repositories;

public class ExercicesRepository : Repository<Exercice>, IExercicesRepository
{
    public ExercicesRepository(FriendsNessDbContext dbContext) : base(dbContext)
    {
    }

    private IQueryable<Exercice> GetAllQueryable()
    {
        return DbContext.Exercices.AsQueryable();
    }

    public async Task<IList<Exercice>> GetAll()
    {
        return await GetAllQueryable().ToListAsync();
    }

    public async Task<Exercice> Get(int id)
    {
        return await GetAllQueryable().FirstOrDefaultAsync(x => x.Id == id);
    }
}
