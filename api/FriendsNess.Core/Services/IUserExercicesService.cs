using FriendsNess.Core.Domain.Exercices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsNess.Core.Services;

public interface IUserExercicesService
{
    Task<IEnumerable<UserExercice>> GetAllUserExercices();
    Task<UserExercice> GetUserExerciceById(int id);
    Task<UserExercice> CreateUserExercice(UserExercice newUserExercice);
    Task UpdateUserExercice(UserExercice userExerciceToBeUpdated, UserExercice userExercice);
    Task DeleteUserExercice(UserExercice userExercice);
}
