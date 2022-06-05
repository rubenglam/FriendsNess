using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsNess.Core.Dtos.PlanningExerciceSet;

public class PlanningExerciceSetResponse
{
    public double Weight { get; set; }
    public int Repetitions { get; set; }
    public int Sets { get; set; }
    public DateTimeOffset Date { get; set; }
    public bool Completed { get; set; }

    public int PlanningExerciceId { get; set; }
    public PlanningExercice PlanningExercice { get; set; }
}
