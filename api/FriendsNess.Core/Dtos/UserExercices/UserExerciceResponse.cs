using FriendsNess.Core.Dtos.Exercices;
using FriendsNess.Core.Dtos.ExerciceSet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsNess.Core.Dtos.UserExercices;

public class UserExerciceResponse
{
    public ExerciceResponse Exercice { get; set; }
    public List<ExerciceSetResponse> ExcerciceSets { get; set; } = new List<ExerciceSetResponse>();
}
