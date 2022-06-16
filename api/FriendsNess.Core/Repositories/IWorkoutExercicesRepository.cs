using FriendsNess.Core.Domain.Exercices;
using FriendsNess.Core.Domain.Workouts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsNess.Core.Repositories;

public interface IWorkoutExercicesRepository
{
    Task<IList<WorkoutExercice>> GetAll();
    Task<WorkoutExercice> Get(int id);
}
