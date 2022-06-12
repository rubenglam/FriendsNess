using FriendsNess.Core.Dtos.Workouts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsNess.Core.Services;

public interface IWorkoutsService
{
    Task<IEnumerable<WorkoutResponse>> GetAllWorkouts();
    Task<WorkoutResponse> GetWorkoutById(int workoutId);
}
