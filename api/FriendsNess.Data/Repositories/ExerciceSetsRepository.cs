using FriendsNess.Core.Domain.Exercices;
using FriendsNess.Core.Domain.Workouts;
using FriendsNess.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsNess.Data.Repositories;

public class ExerciceSetsRepository : Repository<ExerciceSet>, IExerciceSetsRepository
{
    public ExerciceSetsRepository(FriendsNessDbContext context) : base(context)
    {
    }

    private IQueryable<ExerciceSet> GetAllQueryable()
    {
        return DbContext.ExerciceSets.AsQueryable();
    }

    public async Task<IList<ExerciceSet>> GetAll()
    {
        return await GetAllQueryable()
            .ToListAsync();
    }

    public async Task<ExerciceSet> Get(int id)
    {
        return await GetAllQueryable()
            .FirstOrDefaultAsync(x => x.Id == id);
    }
}
