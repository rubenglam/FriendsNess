using FriendsNess.Core.Dtos.Routines;
using FriendsNess.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsNess.Services;

public class RoutinesService : IRoutinesService
{
    public Task<IEnumerable<RoutineResponse>> GetAllRoutines()
    {
        
    }

    public Task<RoutineResponse> GetRoutineById(int routineId)
    {
        
    }
}
