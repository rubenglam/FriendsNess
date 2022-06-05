using FriendsNess.Core.Domain.Exercices;
using FriendsNess.Core.Domain.Planning;
using FriendsNess.Core.Dtos.PlanningExerciceSet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsNess.Core.Dtos.PlanningExercice;

public class PlanningExerciceResponse
{
    public int ExerciceId { get; set; }
    public Exercice Exercice { get; set; }

    public int PlanningId { get; set; }
    public Planning Planning { get; set; }

    public ICollection<PlanningExerciceSetResponse> PlanningExerciceSet { get; set; }
}
