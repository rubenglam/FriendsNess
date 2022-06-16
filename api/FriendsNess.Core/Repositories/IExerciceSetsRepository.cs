using FriendsNess.Core.Domain.Exercices;
using FriendsNess.Core.Domain.Routines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsNess.Core.Repositories;

public interface IExerciceSetsRepository
{
    Task<IList<ExerciceSet>> GetAll();
    Task<ExerciceSet> Get(int id);
}
