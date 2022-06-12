using FriendsNess.Core.Domain.Exercices;
using FriendsNess.Core.Dtos.Exercices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsNess.Core.Services;

public interface IExerciceSetsService
{
    Task<ExerciceSetResponse> GetExerciceSet(int exerciceSetId);
    Task<int> CreateExerciceSet(CreateExerciceSetRequest createExerciceSetRequest);
    Task UpdateExerciceSet(int exerciceSetId, EditExerciceSetRequest editExerciceSetRequest);
    Task RemoveExerciceSet(int exerciceSetId);
}
