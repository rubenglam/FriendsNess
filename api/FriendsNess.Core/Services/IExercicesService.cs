using FriendsNess.Core.Domain.Exercices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsNess.Core.Services;

public interface IExercicesService
{
    Task<IEnumerable<Exercice>> GetAllExercices();
    Task<Exercice> GetExerciceById(int id);
    Task<Exercice> CreateExercice(Exercice newExercice);
    Task UpdateExercice(Exercice exerciceToBeUpdated, Exercice exercice);
    Task DeleteExercice(Exercice exercice);
}
