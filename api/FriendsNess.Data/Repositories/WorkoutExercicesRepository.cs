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

    private IQueryable<WorkoutExercice> GetAllQueryable()
    {
        return DbContext.WorkoutExercices
            .Include(x => x.WorkoutExerciceSets)
            .Include(x => x.Exercice);
    }

    public async Task<IList<WorkoutExercice>> GetAll()
    {
        return await GetAllQueryable().ToListAsync();
    }

    public async Task<WorkoutExercice> Get(int id)
    {
        return await GetAllQueryable().FirstOrDefaultAsync(x => x.Id == id);
    }
}
