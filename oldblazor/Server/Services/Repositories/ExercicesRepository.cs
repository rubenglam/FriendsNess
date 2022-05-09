using FriendsNess.Server.Data;
using FriendsNess.Shared.Domain.Exercices;
using Microsoft.EntityFrameworkCore;

namespace FriendsNess.Server.Services.Repositories;

public interface IExercicesRepository : IRepository<Exercice>
{ 
}

public class ExercicesRepository : Repository<Exercice>, IExercicesRepository
{
    public ExercicesRepository(ApplicationDbContext dbContext) : base(dbContext)
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
