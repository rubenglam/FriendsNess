using FriendsNess.Core.Domain.Exercices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using FriendsNess.Core.Repositories;
using FriendsNess.Services;

namespace FriendsNess.Server.Controllers;

public class ExercicesController : RootController
{
    private readonly ExercicesService _exercicesService;

    public ExercicesController(ExercicesService exercicesService, ILogger<ExercicesController> logger) : base(logger)
    {
        _exercicesService = exercicesService;
    }

    [HttpGet]
    public async Task<ActionResult<List<Exercice>>> GetExercices()
    {
        var exercices = await _exercicesService.GetAllExercices();
        return Ok(exercices.ToList());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Exercice>> GetExercice(int id)
    {
        var exercice = await _exercicesService.GetExerciceById(id);
        if (exercice == null)
        {
            return NotFound();
        }
        return Ok(exercice);
    }

    [HttpPost]
    public async Task<ActionResult<Exercice>> PostExercice(Exercice exercice)
    {
        await _exercicesService.CreateExercice(exercice);
        return Ok(exercice);
    }

    [HttpPut("id")]
    public async Task<ActionResult<Exercice>> PutExercice(int id, Exercice exercice)
    {
        if (id != exercice.Id)
        {
            return BadRequest();
        }

        var dbExercice = await _exercicesService.GetExerciceById(id);

        try
        {
            await _exercicesService.UpdateExercice(dbExercice, exercice);
        }
        catch (Exception ex)
        {
            if (! (await ExerciceExists(id)))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }
        return NoContent();
    }

    [HttpDelete("id")]
    public async Task<ActionResult<Exercice>> DeleteExercice(int id)
    {
        var exercice = await _exercicesService.GetExerciceById(id);
        if (exercice == null)
        {
            return NotFound();
        }

        await _exercicesService.DeleteExercice(exercice);
        return exercice;
    }

    private async Task<bool> ExerciceExists(int id)
    {
        return (await _exercicesService.GetExerciceById(id)) != null;
    }
}
