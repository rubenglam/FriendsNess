using FriendsNess.Core.Domain.Exercices;
using FriendsNess.Core.Dtos.Exercices;
using FriendsNess.Core.Exceptions;
using FriendsNess.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace FriendsNess.Server.Controllers
{
    public class ExerciceSetsController : RootController
    {
        private readonly IExerciceSetsService _exerciceSetsService;

        public ExerciceSetsController(IExerciceSetsService exerciceSetsService, ILogger<ExerciceSetsController> logger) : base(logger)
        {
            _exerciceSetsService = exerciceSetsService;
        }

        [HttpGet("{exerciceSetId}")]
        public async Task<ActionResult<ExerciceSetResponse>> GetExerciceSet(int exerciceSetId)
        {
            try
            {
                var response = await _exerciceSetsService.GetExerciceSet(exerciceSetId);
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

        [HttpPost]
        public async Task<ActionResult> PostExerciceSet(CreateExerciceSetRequest createExerciceSetRequest)
        {
            try
            {
                await _exerciceSetsService.CreateExerciceSet(createExerciceSetRequest);
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

        [HttpPut("{exerciceSetId}")]
        public async Task<ActionResult> PutExercice(int exerciceSetId, EditExerciceSetRequest editExerciceSetRequest)
        {
            try
            {
                await _exerciceSetsService.UpdateExerciceSet(exerciceSetId, editExerciceSetRequest);
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

        [HttpDelete("{exerciceSetId}")]
        public async Task<ActionResult> DeleteExerciceSet(int exerciceSetId)
        {
            try
            {
                await _exerciceSetsService.RemoveExerciceSet(exerciceSetId);
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
}
