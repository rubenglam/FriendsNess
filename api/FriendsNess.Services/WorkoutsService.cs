using AutoMapper;
using FriendsNess.Core.Dtos.Workouts;
using FriendsNess.Core.Repositories;
using FriendsNess.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsNess.Services;

public class WorkoutsService : BaseService, IWorkoutsService
{
    public WorkoutsService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
    {
    }

    public Task<IEnumerable<WorkoutResponse>> GetAllWorkouts()
    {
        throw new NotImplementedException();
    }

    public Task<WorkoutResponse> GetWorkoutById(int workoutId)
    {
        throw new NotImplementedException();
    }
}
