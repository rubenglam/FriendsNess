namespace FriendsNess.Core.Repositories;

public interface IUnitOfWork : IDisposable
{
    IExercicesRepository Exercices { get; }
    IUserExercicesRepository UserExercices { get; }
    IUsersRepository Users { get; }
    IExerciceSetsRepository ExerciceSets { get; }
    IWorkoutExerciceSetsRepository WorkoutExerciceSets { get; }
    IWorkoutExercicesRepository WorkoutExercices { get; }
    IWorkoutsRepository Workouts { get; }
    IRoutinesRepository Routines { get; }
    Task<int> CommitAsync();
}