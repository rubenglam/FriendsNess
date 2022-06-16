using FriendsNess.Core.Domain.Exercices;
using FriendsNess.Core.Dtos.Exercices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsNess.Core.Services;

public interface IExercicesService
{
    Task<IList<ExerciceResponse>> GetAllExercices();
    Task<ExerciceResponse> GetExerciceById(int exerciceId);
}
