using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsNess.Core.Domain.Exercices;

public class ExerciceSet : BaseEntity
{
    public double Weight { get; set; }
    public int Repetitions { get; set; }
    public int Sets { get; set; }
    public DateTimeOffset Date { get; set; }

    public int UserExerciceId { get; set; }
    public UserExercice UserExercice { get; set; }
}
