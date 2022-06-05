using FriendsNess.Core.Domain.Exercices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsNess.Core.Domain.Planning;

public class PlanningExercice : BaseEntity
{
    public int ExerciceId { get; set; }
    public Exercice Exercice { get; set; }

    public int PlanningId { get; set; }
    public Planning Planning { get; set; }

    public ICollection<PlanningExerciceSet> PlanningsExerciceSets { get; set; }
}
