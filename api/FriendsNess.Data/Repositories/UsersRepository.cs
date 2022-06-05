using FriendsNess.Core.Domain.Users;
using FriendsNess.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsNess.Data.Repositories;

internal class UsersRepository : Repository<ApplicationUser>, IUsersRepository
{
    public UsersRepository(FriendsNessDbContext dbContext) : base(dbContext)
    {
    }

    public IQueryable<ApplicationUser> GetAll()
    {
        return DbContext.Users;
    }

    public async Task<ApplicationUser> Get(int id)
    {
        return await GetAll().FirstOrDefaultAsync(x => x.Id == id);
    }
}