using FriendsNess.Core.Domain.Workouts;
using FriendsNess.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsNess.Data.Repositories;

public class WorkoutExercicesRepository : Repository<WorkoutExercice>, IWorkoutExercicesRepository
{
    public WorkoutExercicesRepository(FriendsNessDbContext context) : base(context)
    {
    }

    public IQueryable<WorkoutExercice> GetAll()
    {
        return DbContext.WorkoutExercices
            .Include(x => x.WorkoutExerciceSets)
            .Include(x => x.Exercice);
    }

    public async Task<WorkoutExercice> Get(int id)
    {
        return await GetAll().FirstOrDefaultAsync(x => x.Id == id);
    }
}
