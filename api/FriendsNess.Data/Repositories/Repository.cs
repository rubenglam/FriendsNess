using FriendsNess.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace FriendsNess.Data.Repositories;

public abstract class Repository<TEntity> where TEntity : class
{
    protected readonly FriendsNessDbContext _context;

    public Repository(FriendsNessDbContext context)
    {
        _context = context;
    }

    protected FriendsNessDbContext DbContext => _context;
}
