using AutoMapper;
using FriendsNess.Core.Domain.Exercices;
using FriendsNess.Core.Domain.Users;
using FriendsNess.Core.Dtos.UserExercices;
using FriendsNess.Core.Exceptions;
using FriendsNess.Core.Repositories;
using FriendsNess.Core.Services;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsNess.Services;

public class UserExercicesService : IUserExercicesService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    private readonly UserManager<ApplicationUser> _userManager;

    public UserExercicesService(IUnitOfWork unitOfWork, IMapper mapper, UserManager<ApplicationUser> userManager)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _userManager = userManager;
    }

    public async Task CreateUserExercice(int exerciceId, int userId)
    {
        var user = await _userManager.FindByIdAsync(userId.ToString());
        if (user == null)
        {
            throw new ApiException("User doesn't exists");
        }
        var exercice = await _unitOfWork.Exercices.GetByIdAsync(exerciceId);
        if (exercice == null)
        {
            throw new ApiException("Exercice doesn't exists");
        }
        var userExercice = await _unitOfWork.UserExercices.Get(exerciceId, userId);
        if (userExercice != null)
        {
            throw new ApiException("User exercice existent");
        }
        await _unitOfWork.UserExercices.AddAsync(new UserExercice()
        {
            ExerciceId = exerciceId,
            UserId = userId
        });
        await _unitOfWork.CommitAsync();
    }

    public async Task DeleteUserExercice(int exerciceId, int userId)
    {
        var userExercice = await _unitOfWork.UserExercices.Get(exerciceId, userId);
        if (userExercice == null)
        {
            throw new ApiException("User exercice not found");
        }
        _unitOfWork.UserExercices.Remove(userExercice);
        await _unitOfWork.CommitAsync();
    }

    public async Task<IEnumerable<UserExerciceResponse>> GetAllUserExercicesByUserId(int userId)
    {
        var userExercices = await _unitOfWork.UserExercices.GetAllByUserId(userId);
        var response = _mapper.Map<List<UserExerciceResponse>>(userExercices);
        return response;
    }

    public async Task<UserExerciceResponse> GetUserExercice(int exerciceId, int userId)
    {
        var userExercice = await _unitOfWork.UserExercices.Get(exerciceId, userId);
        var response = _mapper.Map<UserExerciceResponse>(userExercice);
        return response;
    }

    public async Task<UserExerciceResponse> GetUserExerciceById(int userExerciceId)
    {
        var userExercice = await _unitOfWork.UserExercices.GetByIdAsync(userExerciceId);
        var response = _mapper.Map<UserExerciceResponse>(userExercice);
        return response;
    }
}
