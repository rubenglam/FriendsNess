using FriendsNess.Shared.Domain.Exercices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsNess.Shared.Domain.Planning
{
    public class PlanningExerciceSet
    {
        public int Id { get; set; }

        public bool Completed { get; set; }

        public int ExerciceSetId { get; set; }
        public ExerciceSet ExerciceSet { get; set; }
    }
}
