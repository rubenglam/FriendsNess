using FriendsNess.Core.Domain.Exercices;
using FriendsNess.Core.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsNess.Core.Domain.Workouts;

public class Workout : BaseEntity
{
    public Workout()
    {
        WorkoutExercices = new List<WorkoutExercice>();
    }

    public string Name { get; set; }
    public DateTimeOffset Date { get; set; }

    public int UserId { get; set; }
    public ApplicationUser User { get; set; }

    public ICollection<WorkoutExercice> WorkoutExercices { get; set; }
}
