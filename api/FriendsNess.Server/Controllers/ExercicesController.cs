using FriendsNess.Core.Domain.Exercices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using FriendsNess.Core.Repositories;
using FriendsNess.Services;
using AutoMapper;
using FriendsNess.Core.Dtos.Exercices;
using FriendsNess.Core.Services;
using FriendsNess.Core.Exceptions;

namespace FriendsNess.Server.Controllers;

public class ExercicesController : RootController
{
    private readonly IExercicesService _exercicesService;
    private readonly IUserExercicesService _userExercicesService;

    public ExercicesController(IExercicesService exercicesService, IUserExercicesService userExercicesService, ILogger<ExercicesController> logger)
        : base(logger)
    {
        _exercicesService = exercicesService;
        _userExercicesService = userExercicesService;
    }

    [HttpGet]
    public async Task<ActionResult<List<ExerciceResponse>>> GetExercices()
    {
        try
        {
            var response = await _exercicesService.GetAllExercices();
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

    [HttpGet("{exerciceId}")]
    public async Task<ActionResult<ExerciceResponse>> GetExercice(int exerciceId)
    {
        try
        {
            var response = await _exercicesService.GetExerciceById(exerciceId);
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

    [HttpPost("{exerciceId}/users/{userId}")]
    public async Task<ActionResult> PostUserExercice([FromRoute] int exerciceId, [FromRoute] int userId)
    {
        try
        {
            await _userExercicesService.CreateUserExercice(exerciceId, userId);
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

    [HttpDelete("{exerciceId}/users/{userId}")]
    public async Task<ActionResult> DeleteUserExercice([FromRoute] int exerciceId, [FromRoute] int userId)
    {
        try
        {
            await _userExercicesService.DeleteUserExercice(exerciceId, userId);
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

    //[HttpPost]
    //public async Task<ActionResult<Exercice>> PostExercice(Exercice exercice)
    //{
    //    await _exercicesService.CreateExercice(exercice);
    //    return Ok(exercice);
    //}

    //[HttpPut("id")]
    //public async Task<ActionResult<Exercice>> PutExercice(int id, Exercice exercice)
    //{
    //    if (id != exercice.Id)
    //    {
    //        return BadRequest();
    //    }

    //    var dbExercice = await _exercicesService.GetExerciceById(id);

    //    try
    //    {
    //        await _exercicesService.UpdateExercice(dbExercice, exercice);
    //    }
    //    catch (Exception ex)
    //    {
    //        if (! (await ExerciceExists(id)))
    //        {
    //            return NotFound();
    //        }
    //        else
    //        {
    //            throw;
    //        }
    //    }
    //    return NoContent();
    //}

    //[HttpDelete("id")]
    //public async Task<ActionResult<Exercice>> DeleteExercice(int id)
    //{
    //    var exercice = await _exercicesService.GetExerciceById(id);
    //    if (exercice == null)
    //    {
    //        return NotFound();
    //    }

    //    await _exercicesService.DeleteExercice(exercice);
    //    return exercice;
    //}

    //private async Task<bool> ExerciceExists(int id)
    //{
    //    return (await _exercicesService.GetExerciceById(id)) != null;
    //}
}
