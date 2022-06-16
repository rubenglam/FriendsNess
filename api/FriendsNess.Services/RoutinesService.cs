using AutoMapper;
using FriendsNess.Core.Dtos.Routines;
using FriendsNess.Core.Repositories;
using FriendsNess.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsNess.Services;

public class RoutinesService : BaseService, IRoutinesService
{
    public RoutinesService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
    {
    }

    public async Task<IList<RoutineResponse>> GetAllRoutines()
    {
        var routines = await _unitOfWork.Routines.GetAll();
        var response = _mapper.Map<IList<RoutineResponse>>(routines);
        return response;
    }

    public Task<RoutineResponse> GetRoutineById(int routineId)
    {
        throw new NotImplementedException();
    }
}
