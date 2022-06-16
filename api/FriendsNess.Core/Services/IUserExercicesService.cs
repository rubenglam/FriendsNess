using FriendsNess.Core.Domain.Exercices;
using FriendsNess.Core.Dtos.Exercices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsNess.Core.Services;

public interface IUserExercicesService
{
    Task<IList<UserExerciceResponse>> GetAllUserExercicesByUserId(int userId);
    Task<UserExerciceResponse> GetUserExercice(int userId, int exerciceId);
    Task CreateUserExercice(int userId, int exerciceId);
    Task DeleteUserExercice(int userId, int exerciceId);
}
