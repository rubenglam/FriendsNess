using FriendsNess.Core.Dtos.PlanningExercice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsNess.Core.Dtos.Plannings;

public class PlanningResponse
{
    public string Name { get; set; }
    public DateTimeOffset Date { get; set; }

    public List<PlanningExerciceResponse> PlanningExercices { get; set; }
}
