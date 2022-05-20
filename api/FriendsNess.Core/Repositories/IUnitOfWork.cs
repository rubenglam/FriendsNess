namespace FriendsNess.Core.Repositories;

public interface IUnitOfWork : IDisposable
{
    IExercicesRepository Exercices { get; }
    IUserExercicesRepository UserExercices { get; }
    Task<int> CommitAsync();
}