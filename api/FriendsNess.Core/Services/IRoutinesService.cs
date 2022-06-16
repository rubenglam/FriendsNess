using FriendsNess.Core.Dtos.Routines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsNess.Core.Services;

public interface IRoutinesService
{
    Task<IList<RoutineResponse>> GetAllRoutines();
    Task<RoutineResponse> GetRoutineById(int routineId);
}
