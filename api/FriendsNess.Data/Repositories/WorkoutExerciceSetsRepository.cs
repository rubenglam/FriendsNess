using FriendsNess.Core.Domain.Workouts;
using FriendsNess.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsNess.Data.Repositories;

public class WorkoutExerciceSetsRepository : Repository<WorkoutExerciceSet>, IWorkoutExerciceSetsRepository
{
    public WorkoutExerciceSetsRepository(FriendsNessDbContext context) : base(context)
    {
    }

    public IQueryable<WorkoutExerciceSet> GetAll()
    {
        return DbContext.WorkoutExerciceSets;
    }

    public async Task<WorkoutExerciceSet> Get(int id)
    {
        return await GetAll().FirstOrDefaultAsync(x => x.Id == id);
    }
}
