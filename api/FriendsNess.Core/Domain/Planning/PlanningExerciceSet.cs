using FriendsNess.Core.Domain.Exercices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsNess.Core.Domain.Planning
{
    public class PlanningExerciceSet : BaseEntity
    {
        public double Weight { get; set; }
        public int Repetitions { get; set; }
        public int Sets { get; set; }
        public DateTimeOffset Date { get; set; }
        public bool Completed { get; set; }

        public int PlanningExerciceId { get; set; }
        public PlanningExercice PlanningExercice { get; set; }
    }
}
