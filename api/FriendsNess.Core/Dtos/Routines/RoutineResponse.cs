using FriendsNess.Core.Dtos.Workouts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsNess.Core.Dtos.Routines;

public class RoutineResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public List<WorkoutResponse> Workouts { get; set; }
}
