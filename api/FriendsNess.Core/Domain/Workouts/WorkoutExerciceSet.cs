using FriendsNess.Core.Domain.Exercices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsNess.Core.Domain.Workouts;

public class WorkoutExerciceSet : BaseEntity
{
    public double Weight { get; set; }
    public int Repetitions { get; set; }
    public int Sets { get; set; }
    public DateTimeOffset Date { get; set; }
    public bool Completed { get; set; }

    public int WorkoutExerciceId { get; set; }
    public WorkoutExercice WorkoutExercice { get; set; }
}
