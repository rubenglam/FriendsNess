using FriendsNess.Core.Domain.Exercices;
using FriendsNess.Core.Domain.Workouts;
using FriendsNess.Core.Dtos.Exercices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsNess.Core.Dtos.Workouts;

public class WorkoutExerciceResponse
{
    public ExerciceResponse Exercice { get; set; }
    public List<WorkoutExerciceSetResponse> Sets { get; set; }
}
