using FriendsNess.Core.Domain.Exercices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsNess.Core.Domain.Workouts;

public class WorkoutExercice : BaseEntity
{
    public WorkoutExercice()
    {
        WorkoutExerciceSets = new List<WorkoutExerciceSet>();
    }

    public int ExerciceId { get; set; }
    public Exercice Exercice { get; set; }

    public int WorkoutId { get; set; }
    public Workout Workout { get; set; }

    public ICollection<WorkoutExerciceSet> WorkoutExerciceSets { get; set; }
}
