using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsNess.Core.Dtos.Workouts;

public class WorkoutExerciceSetResponse
{
    public int Id { get; set; }
    public double Weight { get; set; }
    public int Repetitions { get; set; }
    public int Sets { get; set; }
    public DateTimeOffset Date { get; set; }
    public bool Completed { get; set; }
}
