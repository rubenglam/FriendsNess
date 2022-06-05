using FriendsNess.Core.Domain.Exercices;
using FriendsNess.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FriendsNess.Data.Repositories;

public class UserExercicesRepository : Repository<UserExercice>, IUserExercicesRepository
{
    public UserExercicesRepository(FriendsNessDbContext dbContext) : base(dbContext)
    {
    }

    public IQueryable<UserExercice> GetAll()
    {
        return DbContext.UserExercices
            .Include(x => x.Exercice)
            .Include(x => x.ExercicesSets);
    }
    public async Task<IList<UserExercice>> GetAllByUserId(int userId)
    {
        return await GetAll().Where(x => x.UserId == userId).ToListAsync();
    }

    public async Task<UserExercice> Get(int userId, int exerciceId)
    {
        return (await GetAllByUserId(userId))
            .FirstOrDefault(x => x.ExerciceId == exerciceId);
    }
}
