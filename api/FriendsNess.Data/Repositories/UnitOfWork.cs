using FriendsNess.Core.Repositories;

namespace FriendsNess.Data.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private FriendsNessDbContext _context;
    private IExercicesRepository _exercicesRepository;
    private IUserExercicesRepository _userExercicesRepository;
    private IUsersRepository _usersRepository;
    private IExerciceSetsRepository _exerciceSetsRepository;
    private IWorkoutsRepository _workoutsRepository;
    private IWorkoutExercicesRepository _workoutExercicesRepository;
    private IWorkoutExerciceSetsRepository _workoutExerciceSetsRepository;
    private IRoutinesRepository _routinesRepository;

    public UnitOfWork(FriendsNessDbContext context)
    {
        _context = context;
    }

    public IExercicesRepository Exercices => _exercicesRepository ??= new ExercicesRepository(_context);
    public IUserExercicesRepository UserExercices => _userExercicesRepository ??= new UsersExercicesRepository(_context);
    public IUsersRepository Users => _usersRepository ??= new UsersRepository(_context);
    public IExerciceSetsRepository ExerciceSets => _exerciceSetsRepository ??= new ExerciceSetsRepository(_context);
    public IWorkoutsRepository Workouts => _workoutsRepository ??= new WorkoutsRepository(_context);
    public IWorkoutExercicesRepository WorkoutExercices => _workoutExercicesRepository ??= new WorkoutExercicesRepository(_context);
    public IWorkoutExerciceSetsRepository WorkoutExerciceSets => _workoutExerciceSetsRepository ??= new WorkoutExerciceSetsRepository(_context);
    public IRoutinesRepository Routines => _routinesRepository ??= new RoutinesRepository(_context);

    public async Task<int> CommitAsync()
    {
        return await _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}
