using FriendsNess.Core.Domain.Exercices;
using FriendsNess.Core.Repositories;
using FriendsNess.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsNess.Services;

public class UserExercicesService : IUserExercicesService
{
    private readonly IUnitOfWork _unitOfWork;

    public UserExercicesService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<UserExercice> CreateUserExercice(UserExercice newUserExercice)
    {
        await _unitOfWork.UserExercices.AddAsync(newUserExercice);
        await _unitOfWork.CommitAsync();
        return newUserExercice;
    }

    public async Task DeleteUserExercice(UserExercice userExercice)
    {
        _unitOfWork.UserExercices.Remove(userExercice);
        await _unitOfWork.CommitAsync();
    }

    public async Task<IEnumerable<UserExercice>> GetAllUserExercices()
    {
        return await _unitOfWork.UserExercices.GetAllAsync();
    }

    public async Task<UserExercice> GetUserExerciceById(int id)
    {
        return await _unitOfWork.UserExercices.GetByIdAsync(id);
    }

    public async Task UpdateUserExercice(UserExercice userExerciceToBeUpdated, UserExercice userExercice)
    {
        await _unitOfWork.CommitAsync();
    }
}
