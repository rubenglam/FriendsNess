﻿using FriendsNess.Core.Domain.Exercices;
using FriendsNess.Core.Dtos.UserExercices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsNess.Core.Services;

public interface IUserExercicesService
{
    Task<IEnumerable<UserExerciceResponse>> GetAllUserExercicesByUserId(int userId);
    Task<UserExerciceResponse> GetUserExercice(int userId, int exerciceId);
    Task CreateUserExercice(int exerciceId, int userId);
    Task DeleteUserExercice(int exerciceId, int userId);
}
