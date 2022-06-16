using FriendsNess.Core.Domain.Exercices;
using FriendsNess.Core.Domain.Workouts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsNess.Core.Repositories;

public interface IWorkoutExerciceSetsRepository
{
    Task<IList<WorkoutExerciceSet>> GetAll();
    Task<WorkoutExerciceSet> Get(int id);
}
