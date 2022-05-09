using FriendsNess.Server.Services.Repositories;
using FriendsNess.Core;
using FriendsNess.Core.Domain.Exercices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FriendsNess.Server.Controllers;

[AllowAnonymous]
public class ExercicesController : RootController
{
    public ExercicesController(IUnitOfRepositories unitOfRepositories, ILogger<ExercicesController> logger) : base(unitOfRepositories, logger)
    {
    }

    [HttpGet]
    public ActionResult<List<Exercice>> GetExercices()
    {
        return Ok(UnitOfRepositories.ExercicesRepository.FindAll().ToList());
    }

    [HttpGet("{id}")]
    public ActionResult<Exercice> GetExercice(int id)
    {
        var exercice = UnitOfRepositories.ExercicesRepository.FindByCondition(x => x.Id == id).First();
        if (exercice == null)
        {
            return NotFound();
        }
        return Ok(exercice);
    }

    [HttpPost]
    public async Task<ActionResult<Exercice>> PostExercice(Exercice exercice)
    {
        UnitOfRepositories.ExercicesRepository.Create(exercice);
        await UnitOfRepositories.SaveAsync();
        return Ok(exercice);
    }

    [HttpPut("id")]
    public async Task<ActionResult<Exercice>> PutExercice(int id, Exercice exercice)
    {
        if (id != exercice.Id)
        {
            return BadRequest();
        }

        UnitOfRepositories.ExercicesRepository.Update(exercice);

        try
        {
            await UnitOfRepositories.SaveAsync();
        }
        catch (Exception ex)
        {
            if (!ExerciceExists(id))
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
        var exercice = UnitOfRepositories.ExercicesRepository.FindByCondition(x => x.Id == id).First();
        if (exercice == null)
        {
            return NotFound();
        }

        UnitOfRepositories.ExercicesRepository.Delete(exercice);
        await UnitOfRepositories.SaveAsync();
        return exercice;
    }

    private bool ExerciceExists(int id)
    {
        return UnitOfRepositories.ExercicesRepository.FindByCondition(x => x.Id == id).Any();
    }
}
