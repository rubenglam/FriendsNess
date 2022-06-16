using AutoMapper;
using FriendsNess.Core.Domain.Exercices;
using FriendsNess.Core.Dtos.Exercices;
using FriendsNess.Core.Exceptions;
using FriendsNess.Core.Repositories;
using FriendsNess.Core.Services;
using FriendsNess.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsNess.Services;

public class ExercicesService : BaseService, IExercicesService
{
    public ExercicesService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
    {
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

    public async Task<IList<ExerciceResponse>> GetAllExercices()
    {
        var exercices = await _unitOfWork.Exercices.GetAll();
        var response = _mapper.Map<IList<ExerciceResponse>>(exercices);
        return response;
    }

    public async Task<ExerciceResponse> GetExerciceById(int exerciceId)
    {
        var exercice = await _unitOfWork.Exercices.Get(exerciceId);
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