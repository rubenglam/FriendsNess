using FriendsNess.Server.Data;

namespace FriendsNess.Server.Services.Repositories
{
    public interface IUnitOfRepositories
    {
        public IExercicesRepository ExercicesRepository { get; }
        public IUserExercicesRepository UserExercicesRepository { get; }
        void Save();
        Task SaveAsync();
    }

    public class UnitOfRepositories : IUnitOfRepositories
    {
        private ApplicationDbContext _dbContext;
        private IExercicesRepository _exercicesRepository;
        private IUserExercicesRepository _userExercicesRepository;

        public UnitOfRepositories(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IExercicesRepository ExercicesRepository
        {
            get
            {
                if (_exercicesRepository == null)
                {
                    _exercicesRepository = new ExercicesRepository(_dbContext);
                }
                return _exercicesRepository;
            }
        }

        public IUserExercicesRepository UserExercicesRepository
        {
            get
            {
                if (_userExercicesRepository == null)
                {
                    _userExercicesRepository = new UserExercicesRepository(_dbContext);
                }
                return _userExercicesRepository;
            }
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public async Task SaveAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
