using FriendsNess.Core.Dtos.Routines;
using FriendsNess.Core.Exceptions;
using FriendsNess.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace FriendsNess.Server.Controllers;

public class RoutinesController : RootController
{
    private readonly IRoutinesService _routinesService;

    public RoutinesController(ILogger<RoutinesController> logger, IRoutinesService routinesService) : base(logger)
    {
        _routinesService = routinesService;
    }

    [HttpGet]
    public async Task<ActionResult<List<RoutineResponse>>> GetRoutines()
    {
        try
        {
            var response = await _routinesService.GetAllRoutines();
            return Success(response);
        }
        catch (ApiException apiException)
        {
            return Error(apiException);
        }
        catch (Exception exception)
        {
            return Error(exception);
        }
    }

    [HttpGet("{routineId}")]
    public async Task<ActionResult<RoutineResponse>> GetRoutine(int routineId)
    {
        try
        {
            var response = await _routinesService.GetRoutineById(routineId);
            return Success(response);
        }
        catch (ApiException apiException)
        {
            return Error(apiException);
        }
        catch (Exception exception)
        {
            return Error(exception);
        }
    }
}
