﻿using FriendsNess.Core.Domain.Routines;
using FriendsNess.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsNess.Data.Repositories;

public class RoutinesRepository : Repository<Routine>, IRoutinesRepository
{
    public RoutinesRepository(FriendsNessDbContext context) : base(context)
    {
    }

    public IQueryable<Routine> GetAll()
    {
        return DbContext.Routines
            .Include(x => x.Workouts)
                .ThenInclude(x => x.WorkoutExercices)
                .ThenInclude(x => x.WorkoutExerciceSets)
            .Include(x => x.Workouts)
                .ThenInclude(x => x.WorkoutExercices)
                .ThenInclude(x => x.Exercice);
    }

    public async Task<Routine> Get(int id)
    {
        return await GetAll().FirstOrDefaultAsync(x => x.Id == id);
    }
}
