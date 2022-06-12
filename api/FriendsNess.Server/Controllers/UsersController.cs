using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using FriendsNess.Core.Dtos.Users;
using AutoMapper;
using FriendsNess.Core.Services;
using FriendsNess.Core.Exceptions;
using FriendsNess.Core.Dtos.Exercices;

namespace FriendsNess.Server.Controllers;

[AllowAnonymous]
public class UsersController : RootController
{
    private readonly IUsersService _usersService;
    private readonly IUserExercicesService _userExercicesService;
    private readonly IMapper _mapper;

    public UsersController(ILogger<ExercicesController> logger, IMapper mapper, IUsersService usersService, IUserExercicesService userExercicesService) : base(logger)
    {
        _mapper = mapper;
        _usersService = usersService;
        _userExercicesService = userExercicesService;
    }

    [HttpGet]
    public async Task<ActionResult<List<UserResponse>>> GetUsers()
    {
        try
        {
            var response = await _usersService.GetAllUsers();
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

    [HttpGet("{userId}")]
    public async Task<ActionResult<UserResponse>> GetUser(int userId)
    {
        try
        {
            var response = await _usersService.GetUserById(userId);
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


    [HttpGet("{userId}/exercices")]
    public async Task<ActionResult<List<UserExerciceResponse>>> GetUserExercices([FromRoute] int userId)
    {
        try
        {
            var response = await _userExercicesService.GetAllUserExercicesByUserId(userId);
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

    [HttpGet("{userId}/exercices/{exerciceId}")]
    public async Task<ActionResult<List<UserExerciceResponse>>> GetUserExercice([FromRoute] int userId, [FromRoute] int exerciceId)
    {
        try
        {
            var response = await _userExercicesService.GetUserExercice(userId, exerciceId);
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

    [HttpPost("{userId}/exercices/{exerciceId}")]
    public async Task<ActionResult> PostUserExercice([FromRoute] int userId, [FromRoute] int exerciceId)
    {
        try
        {
            await _userExercicesService.CreateUserExercice(userId, exerciceId);
            return Success();
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

    [HttpDelete("{userId}/exercices/{exerciceId}")]
    public async Task<ActionResult> DeleteUserExercice([FromRoute] int userId, [FromRoute] int exerciceId)
    {
        try
        {
            await _userExercicesService.DeleteUserExercice(userId, exerciceId);
            return Success();
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
