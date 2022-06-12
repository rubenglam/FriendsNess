using FriendsNess.Core.Domain.Exercices;

namespace FriendsNess.Core.Repositories;

public interface IUserExercicesRepository : IRepository<UserExercice>
{
    Task<IList<UserExercice>> GetAllByUserId(int userId);
    Task<UserExercice> Get(int userId, int exerciceId);
}