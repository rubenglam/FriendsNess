using FriendsNess.Core.Domain.Workouts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsNess.Core.Domain.Routines
{
    public class Routine : BaseEntity
    {
        public Routine()
        {
            Workouts = new List<Workout>();
        }

        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Workout> Workouts { get; set; }
    }
}
