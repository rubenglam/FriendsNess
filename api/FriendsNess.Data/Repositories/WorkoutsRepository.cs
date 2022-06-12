using FriendsNess.Core.Domain.Workouts;
using FriendsNess.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsNess.Data.Repositories;

public class WorkoutsRepository : Repository<Workout>, IWorkoutsRepository
{
    public WorkoutsRepository(FriendsNessDbContext context) : base(context)
    {
    }

    public IQueryable<Workout> GetAll()
    {
        return DbContext.Workouts
            .Include(x => x.WorkoutExercices)
                .ThenInclude(x => x.WorkoutExerciceSets)
            .Include(x => x.WorkoutExercices)
                .ThenInclude(x => x.Exercice);
    }

    public async Task<Workout> Get(int id)
    {
        return await GetAll().FirstOrDefaultAsync(x => x.Id == id);
    }
}
