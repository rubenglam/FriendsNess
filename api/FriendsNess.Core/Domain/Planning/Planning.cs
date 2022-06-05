using FriendsNess.Core.Domain.Exercices;
using FriendsNess.Core.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsNess.Core.Domain.Planning;

public class Planning : BaseEntity
{
    public string Name { get; set; }
    public DateTimeOffset Date { get; set; }

    public int UserId { get; set; }
    public ApplicationUser User { get; set; }

    public ICollection<PlanningExercice> PlanningsExercices { get; set; }
}
