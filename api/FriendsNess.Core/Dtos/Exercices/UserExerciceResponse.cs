using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsNess.Core.Dtos.Exercices;

public class UserExerciceResponse
{
    public ExerciceResponse Exercice { get; set; }
    public List<ExerciceSetResponse> Sets { get; set; }
}
