using FriendsNess.Core.Domain.Exercices;

namespace FriendsNess.Core.Repositories;

public interface IExercicesRepository
{
    Task<IList<Exercice>> GetAll();
    Task<Exercice> Get(int id);
}