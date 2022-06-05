using AutoMapper;
using FriendsNess.Core.Domain.Exercices;
using FriendsNess.Core.Dtos.ExerciceSet;
using FriendsNess.Core.Exceptions;
using FriendsNess.Core.Repositories;
using FriendsNess.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsNess.Services;

public class ExerciceSetsService : IExerciceSetsService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public ExerciceSetsService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<int> CreateExerciceSet(CreateExerciceSetRequest createExerciceSetRequest)
    {
        var exerciceSet = _mapper.Map<ExerciceSet>(createExerciceSetRequest);
        await _unitOfWork.ExerciceSets.AddAsync(exerciceSet);
        await _unitOfWork.CommitAsync();
        return exerciceSet.Id;
    }

    public async Task<ExerciceSetResponse> GetExerciceSet(int exerciceSetId)
    {
        var exerciceSet = await _unitOfWork.ExerciceSets.GetByIdAsync(exerciceSetId);
        if (exerciceSet == null)
        {
            throw new ApiException("No exercice set found");
        }
        var response = _mapper.Map<ExerciceSetResponse>(exerciceSet);
        return response;
    }

    public async Task RemoveExerciceSet(int exerciceSetId)
    {
        var exerciceSet = await _unitOfWork.ExerciceSets.GetByIdAsync(exerciceSetId);
        if (exerciceSet == null)
        {
            throw new ApiException("No exercice set found");
        }
        _unitOfWork.ExerciceSets.Remove(exerciceSet);
        await _unitOfWork.CommitAsync();
    }

    public async Task UpdateExerciceSet(int exerciceSetId, EditExerciceSetRequest editExerciceSetRequest)
    {
        var exerciceSet = await _unitOfWork.ExerciceSets.GetByIdAsync(exerciceSetId);
        if (exerciceSet == null)
        {
            throw new ApiException("No exercice set found");
        }
        _unitOfWork.ExerciceSets.Update(exerciceSet);
        await _unitOfWork.CommitAsync();
    }
}
