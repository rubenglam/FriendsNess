using FriendsNess.Core.Domain.Exercices;
using FriendsNess.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsNess.Data.Repositories;

public class ExerciceSetsRepository : Repository<ExerciceSet>, IExerciceSetsRepository
{
    public ExerciceSetsRepository(FriendsNessDbContext context) : base(context)
    {
    }
}
