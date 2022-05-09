using FriendsNess.Server.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace FriendsNess.Server.Services.Repositories;

public interface IRepository<T>
{
    IQueryable<T> FindAll();
    IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);
    void Create(T entity);
    void Update(T entity);
    void Delete(T entity);
}

public abstract class Repository<T> : IRepository<T> where T : class
{
    private readonly ApplicationDbContext _dbContext;

    public Repository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IQueryable<T> FindAll() => _dbContext.Set<T>().AsNoTracking();
    public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression) => _dbContext.Set<T>().Where(expression).AsNoTracking();
    public void Create(T entity) => _dbContext.Set<T>().Add(entity);
    public void Update(T entity) => _dbContext.Set<T>().Update(entity);
    public void Delete(T entity) => _dbContext.Set<T>().Remove(entity);

    protected ApplicationDbContext DbContext => _dbContext;
}
