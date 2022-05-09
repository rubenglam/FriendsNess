using FriendsNess.Server.Data;
using FriendsNess.Core.Domain.Exercices;
using Microsoft.EntityFrameworkCore;

namespace FriendsNess.Server.Services.Repositories;

public interface IUserExercicesRepository : IRepository<UserExercice>
{
}

public class UserExercicesRepository : Repository<UserExercice>, IUserExercicesRepository
{
    public UserExercicesRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }

    public IQueryable<UserExercice> GetAll()
    {
        return DbContext.UserExercices
            .Include(x => x.Exercice)
            .Include(x => x.ExerciceSets);
    }

    public async Task<UserExercice> Get(int userId, int exerciceId)
    {
        return await GetAll().FirstOrDefaultAsync(x => x.UserId == userId && x.ExerciceId == exerciceId);
    }
}
