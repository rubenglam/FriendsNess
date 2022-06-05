namespace FriendsNess.Core.Repositories;

public interface IUnitOfWork : IDisposable
{
    IExercicesRepository Exercices { get; }
    IUserExercicesRepository UserExercices { get; }
    IUsersRepository Users { get; }
    IExerciceSetsRepository ExerciceSets { get; }
    Task<int> CommitAsync();
}