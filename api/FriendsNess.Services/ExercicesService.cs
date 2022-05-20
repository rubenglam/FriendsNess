using FriendsNess.Core.Domain.Exercices;
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

    public ExercicesService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<Exercice> CreateExercice(Exercice newExercice)
    {
        await _unitOfWork.Exercices.AddAsync(newExercice);
        await _unitOfWork.CommitAsync();
        return newExercice;
    }

    public async Task DeleteExercice(Exercice exercice)
    {
        _unitOfWork.Exercices.Remove(exercice);
        await _unitOfWork.CommitAsync();
    }

    public async Task<IEnumerable<Exercice>> GetAllExercices()
    {
        return await _unitOfWork.Exercices.GetAllAsync();
    }

    public async Task<Exercice> GetExerciceById(int id)
    {
        return await _unitOfWork.Exercices.GetByIdAsync(id);
    }

    public async Task UpdateExercice(Exercice exerciceToBeUpdated, Exercice exercice)
    {
        exerciceToBeUpdated.Name = exercice.Name;
        await _unitOfWork.CommitAsync();
    }
}