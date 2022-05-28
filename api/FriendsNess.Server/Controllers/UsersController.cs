using FriendsNess.Core.Domain.Exercices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using FriendsNess.Core.Repositories;
using FriendsNess.Core.Dtos.Users;

namespace FriendsNess.Server.Controllers;

[AllowAnonymous]
public class UsersController : RootController
{
    public UsersController(ILogger<ExercicesController> logger) : base (logger)
    {
    }

    public async Task<ActionResult<List<UserResponse>>> GetUsers()
    {
        
    }

    [HttpGet("{userId}")]
    public async Task<ActionResult<UserResponse>> GetUser(Guid userId)
    {

    }

    //[HttpGet]
    //public ActionResult<List<UserExercice>> GetUserExercices()
    //{
    //    return UnitOfRepositories.UserExercicesRepository.FindAll().ToList();
    //}

    //[HttpGet("{id}")]
    //public ActionResult<UserExercice> GetUserExercice(int id)
    //{
    //    var userExercice = UnitOfRepositories.UserExercicesRepository.FindByCondition(x => x.ExerciceId == id).First();
    //    if (userExercice == null)
    //    {
    //        return NotFound();
    //    }
    //    return Ok(userExercice);
    //}

    //[HttpPost]
    //public async Task<ActionResult<UserExercice>> PostUserExercice(UserExercice userExercice)
    //{
    //    UnitOfRepositories.UserExercicesRepository.Create(userExercice);
    //    await UnitOfRepositories.SaveAsync();
    //    return Ok(userExercice);
    //}

    //[HttpPut("id")]
    //public async Task<ActionResult<UserExercice>> PutUserExercice(int id, UserExercice userExercice)
    //{
    //    if (id != userExercice.ExerciceId)
    //    {
    //        return BadRequest();
    //    }

    //    UnitOfRepositories.UserExercicesRepository.Update(userExercice);

    //    try
    //    {
    //        await UnitOfRepositories.SaveAsync();
    //    }
    //    catch (Exception ex)
    //    {
    //        if (!UserExerciceExists(id))
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
    //public async Task<ActionResult<UserExercice>> DeleteUserExercice(int id)
    //{
    //    var userExercice = UnitOfRepositories.UserExercicesRepository.FindByCondition(x => x.ExerciceId == id).First();
    //    if (userExercice == null)
    //    {
    //        return NotFound();
    //    }

    //    UnitOfRepositories.UserExercicesRepository.Delete(userExercice);
    //    await UnitOfRepositories.SaveAsync();
    //    return userExercice;
    //}

    //private bool UserExerciceExists(int id)
    //{
    //    return UnitOfRepositories.UserExercicesRepository.FindByCondition(x => x.ExerciceId == id).Any();
    //}
}
