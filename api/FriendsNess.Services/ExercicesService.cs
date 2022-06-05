using AutoMapper;
using FriendsNess.Core.Domain.Exercices;
using FriendsNess.Core.Dtos.Exercices;
using FriendsNess.Core.Exceptions;
using FriendsNess.Core.Repositories;
using FriendsNess.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsNess.Services;

public class ExercicesService : IExercicesService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public ExercicesService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    //public async Task<Exercice> CreateExercice(Exercice newExercice)
    //{
    //    await _unitOfWork.Exercices.AddAsync(newExercice);
    //    await _unitOfWork.CommitAsync();
    //    return newExercice;
    //}

    //public async Task DeleteExercice(Exercice exercice)
    //{
    //    _unitOfWork.Exercices.Remove(exercice);
    //    await _unitOfWork.CommitAsync();
    //}

    public async Task<IEnumerable<ExerciceResponse>> GetAllExercices()
    {
        var exercices = await _unitOfWork.Exercices.GetAllAsync();
        var response = _mapper.Map<List<ExerciceResponse>>(exercices);
        return response;
    }

    public async Task<ExerciceResponse> GetExerciceById(int exerciceId)
    {
        var exercice = await _unitOfWork.Exercices.GetByIdAsync(exerciceId);
        if (exercice == null)
        {
            throw new ApiException("No exercice found");
        }
        var response = _mapper.Map<ExerciceResponse>(exercice);
        return response;
    }

    //public async Task UpdateExercice(Exercice exerciceToBeUpdated, Exercice exercice)
    //{
    //    exerciceToBeUpdated.Name = exercice.Name;
    //    await _unitOfWork.CommitAsync();
    //}
}